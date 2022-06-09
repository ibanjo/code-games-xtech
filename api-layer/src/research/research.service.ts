import { Injectable } from '@nestjs/common';
import { ResearchDto } from './dto/research.dto';
import { validate } from 'class-validator';
import { instanceToInstance, instanceToPlain, plainToInstance } from 'class-transformer';
import { HttpException } from '@nestjs/common/exceptions/http.exception';
import { HttpStatus } from '@nestjs/common';
import { CreateResearchDto } from './dto/create-research.dto';
import { DataLayerClient } from 'src/adapter/data-layer';

@Injectable()
export class ResearchService {
    constructor(private readonly dataLayer: DataLayerClient) { }

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
            let research = {
                code: dto.code,
                description: dto.description,
                remote: dto.remote,
                siteId: dto.siteId,
                personId: dto.userId,
                languageId: dto.languageID,
                init: null,
                toJSON: null
            };
            // data access layer
            const result = await this.dataLayer.researchPOST(research);
            const res = (await this.dataLayer.researchAll()).pop();
            const finalResearch = instanceToInstance<ResearchDto>(research);
            finalResearch.researchId = res.researchId; 
            // return saved match
            return finalResearch;
        }
    }
}
