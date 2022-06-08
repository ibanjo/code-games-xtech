import { Get, Controller, Query, Param, ParseUUIDPipe } from '@nestjs/common';
import { SkillService } from './skill.service';
import { SkillListDto,UserSkillListDto } from './dto/skill.dto';

@Controller('skills')
export class SkillController {
    constructor(private readonly skillService: SkillService) { }

    @Get()
    async findAll(@Query() query): Promise<SkillListDto> {
        return await this.skillService.findAll(query);
    }

    @Get(':userId')
    async findByUserId(@Query() query, @Param('userId', ParseUUIDPipe) userId: string): Promise<UserSkillListDto> {
        return await this.skillService.findByUserId(query, userId);
    }
}