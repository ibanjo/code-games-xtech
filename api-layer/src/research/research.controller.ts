import { Get, Post, Body, Controller, HttpCode, ParseUUIDPipe, Param } from '@nestjs/common';
import { ResearchService } from './research.service';
import { ResearchDto } from './dto/research.dto';
import { CreateResearchDto } from './dto/create-research.dto';

@Controller('researches')
export class ResearchController {
    constructor(private readonly researchService: ResearchService) { }

    @Get(':id')
    async findResearch(@Param('id', ParseUUIDPipe) id: string): Promise<ResearchDto> {
        return await this.researchService.findById(id);
    }

    @Post('create-research')
    @HttpCode(204)
    async create(@Body() researchData: CreateResearchDto): Promise<ResearchDto> {
        var result = await this.researchService.create(researchData);
        console.log(result);
        return result;
    }
}