import { Injectable } from '@nestjs/common';
import { SiteListDto } from './dto/site.dto';

@Injectable()
export class SiteService {
    async findAll(): Promise<SiteListDto> {
        // data access layer
        const sites = [
            {
                siteId: '1',
                code: 1,
                description: ''
            },
            {
                siteId: '2',
                code: 1,
                description: ''
            }
        ];
        const sitesCount = sites.length;
        return { sites, sitesCount };
    }

    async findByUserId(query, userId: string): Promise<SiteListDto> {
        // data access layer
        const sites = [
            {
                siteId: '1',
                code: 1,
                description: '',
                userId: '1',
                siteLevelCode: 'C1',
                siteLevelDescription: 'C1',
                preferred: true
            },
            {
                siteId: '2',
                code: 1,
                description: '',
                userId: '1',
                siteLevelCode: 'B1',
                siteLevelDescription: 'B1',
                preferred: false
            }
        ];
        const sitesCount = sites.length;
        return { sites, sitesCount };
    }
}
