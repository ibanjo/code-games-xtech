import { Get, Controller, ParseUUIDPipe, Query, Param} from '@nestjs/common';
import { LanguageService } from './language.service';
import { LanguageListDto } from './dto/language.dto';

@Controller('languages')
export class LanguageController {
    constructor(private readonly languageService: LanguageService) { }

    @Get()
    async findAll(): Promise<LanguageListDto> {
        return await this.languageService.findAll();
    }

    @Get(':userId')
    async findByUserId(@Query() query, @Param('userId', ParseUUIDPipe) userId: string): Promise<LanguageListDto> {
        return await this.languageService.findByUserId(query, userId);
    }
}