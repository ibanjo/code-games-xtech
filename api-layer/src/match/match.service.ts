import { Injectable } from '@nestjs/common';
import { MatchDto, MatchListDto } from './dto/match.dto';
import { validate } from 'class-validator';
import { instanceToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateMatchDto } from './dto/create-match.dto';
import { UpdateMatchDto } from './dto/update-match.dto';
import { ConfigService } from '@nestjs/config';
import { DataLayerClient } from 'src/adapter/data-layer';

@Injectable()
export class MatchService {
    constructor(private readonly configService: ConfigService, private readonly dataLayer: DataLayerClient) { }

    async findAll(query): Promise<MatchListDto> {
        // data access layer
        const matches = [
            {
                matchId: '1',
                researchId: query.researchId,
                recruiterId: '1',
                userId: '1',
                matchAccepted: true
            },
            {
                matchId: '2',
                researchId: query.researchId,
                recruiterId: '1',
                userId: '2',
                matchAccepted: true
            }
        ];
        const matchesCount = matches.length;
        return { matches, matchesCount };
    }

    async findById(id: string): Promise<MatchDto> {
        // get match
        const match = await this.find(id);
        // throw error if not found
        if (!match) {
            const errors = { Match: ' not found' };
            throw new HttpException({ errors }, 401);
        }
        // return match
        return instanceToInstance<MatchDto>(match);
    }

    private async find(id: string): Promise<any> {
        // data access layer
        const match = {
            matchId: '1',
            researchId: '1',
            recruiterId: '1',
            userId: '1',
            matchAccepted: true
        };
        return match;
    }

    async create(dto: CreateMatchDto): Promise<MatchDto> {
        // validate
        const errors = await validate(dto);
        if (errors.length > 0) {
            throw new HttpException({ message: 'Input data validation failed', errors }, HttpStatus.BAD_REQUEST);
        } else {
            // create new match
            let m = {
                personId: dto.userId,
                researchId: dto.researchId,
                matchAcceptedByEmployee: false,
                init: null,
                toJSON: null
            };
            // data access layer
            let result = await this.dataLayer.matchPOST(m);

            // return saved match
            return instanceToInstance<MatchDto>(m);
        }
    }

    async update(id: string, dto: UpdateMatchDto): Promise<MatchDto> {
        // validate
        const errors = await validate(dto);
        if (errors.length > 0) {
            throw new HttpException({ message: 'Input data validation failed', errors }, HttpStatus.BAD_REQUEST);
        } else {
            // update match
            let matchToUpdate = await this.find(id);
            delete matchToUpdate.matchAccepted;
            let updateMatch = Object.assign(matchToUpdate, dto);
            // data access layer
            const match = {
                matchId: '1',
                researchId: '1',
                userId: '1',
                recruiterId: '1',
                matchAccepted: false
            };
            // return saved match
            return instanceToInstance<MatchDto>(updateMatch);
        }
    }
}
