import { Injectable } from '@nestjs/common';
import { ResearchDto } from './dto/research.dto';
import { validate } from 'class-validator';
import { instanceToPlain, plainToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateResearchDto } from './dto/create-research.dto';

@Injectable()
export class ResearchService {

    async findById(id: string): Promise<ResearchDto> {
        // get research
        const research = {
            researchId: '1',
            code: 10,
            description: '234342',
            remote: true,
            siteId: '1',
            userId: '1'
        };
        // throw error if not found
        if (!research) {
            const errors = { Research: ' not found' };
            throw new HttpException({ errors }, 401);
        }
        // return research
        return plainToInstance(ResearchDto, research);
    }

    async create(dto: CreateResearchDto): Promise<ResearchDto> {
        // validate
        const errors = await validate(dto);
        if (errors.length > 0) {
            throw new HttpException({ message: 'Input data validation failed', errors }, HttpStatus.BAD_REQUEST);
        } else {
            // create new research
            let newResearch = instanceToPlain(dto);
            // data access layer
            const research = {
                researchId: '1',
                code: 10,
                description: '234342',
                remote: true,
                siteId: '1',
                userId: '1'
            };
            // return saved research
            return plainToInstance(ResearchDto, research);
        }
    }
}
