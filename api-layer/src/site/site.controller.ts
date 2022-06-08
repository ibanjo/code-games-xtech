import { Get, Controller } from '@nestjs/common';
import { SiteService } from './site.service';
import { SiteListDto } from './dto/site.dto';

@Controller('sites')
export class SiteController {
    constructor(private readonly siteService: SiteService) { }

    @Get()
    async findAll(): Promise<SiteListDto> {
        return await this.siteService.findAll();
    }
}