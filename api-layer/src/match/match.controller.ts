import { Get, Post, Put, Body, Controller, HttpCode, ParseIntPipe, Param, ParseUUIDPipe, Query } from '@nestjs/common';
import { MatchService } from './match.service';
import { MatchDto, MatchListDto } from './dto/match.dto';
import { CreateMatchDto } from './dto/create-match.dto';
import { UpdateMatchDto } from './dto/update-match.dto';

@Controller('matches')
export class MatchController {
    constructor(private readonly matchService: MatchService) { }

    @Get()
    async findAll(@Query() query) : Promise<MatchListDto> {
        return await this.matchService.findAll(query);
    }

    @Get(':id')
    async findMatch(@Param('id', ParseUUIDPipe) id: string): Promise<MatchDto> {
        return await this.matchService.findById(id);
    }

    @Post('create-match')
    @HttpCode(204)
    async create(@Body() matchData: CreateMatchDto): Promise<MatchDto> {
        return await this.matchService.create(matchData);
    }

    @Put(':id')
    async update(@Param('id') id: string, @Body() matchData: UpdateMatchDto) {
        return await this.matchService.update(id, matchData);
    }
}