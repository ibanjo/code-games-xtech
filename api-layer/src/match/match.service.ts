import { Injectable } from '@nestjs/common';
import { MatchDto, MatchListDto } from './dto/match.dto';
import { validate } from 'class-validator';
import { instanceToPlain, plainToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateMatchDto } from './dto/create-match.dto';
import { UpdateMatchDto } from './dto/update-match.dto';

@Injectable()
export class MatchService {

    async findAll(query): Promise<MatchListDto> {
        //researchId
        //includeMatchPending
        // data access layer
        const matches = [
            {
                matchId: '1',
                researchId: query.researchId,
                userId: '1',
                matchAccepted: true
            }, 
            {
                matchId: '2',
                researchId: query.researchId,
                userId: '2',
                matchAccepted: true
            }
        ];
        const matchesCount = matches.length;
        return {matches, matchesCount};
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
        return plainToInstance(MatchDto, match);
    }

    private async find(id: string): Promise<any> {
        // data access layer
        const match = {
            matchId: '1',
            researchId: '1',
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
            let newMatch = instanceToPlain(dto);
            // data access layer
            const match = {
                matchId: '1',
                researchId: '1',
                userId: '1'
            };
            // return saved match
            return plainToInstance(MatchDto, match);
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
            let updateMatch = instanceToPlain(Object.assign(matchToUpdate, dto));
            // data access layer
            const match = {
                matchId: '1',
                researchId: '1',
                userId: '1',
                matchAccepted: true
            };
            // return saved match
            return plainToInstance(MatchDto, match);
        }
    }
}
