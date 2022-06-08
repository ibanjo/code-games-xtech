import { Injectable } from '@nestjs/common';
import { LanguageDto, LanguageListDto } from './dto/language.dto';
import { DataLayerClient } from 'src/adapter/data-layer';
import { instanceToInstance } from 'class-transformer';

@Injectable()
export class LanguageService {

    constructor(private dataLayer: DataLayerClient) { }

    async findAll(): Promise<LanguageListDto> {
        // data access layer
        const languagesEntities = await this.dataLayer.languageAll();
        const languages = instanceToInstance<LanguageDto[]>(languagesEntities);
        const languagesCount = languagesEntities.length;
        return { languages, languagesCount };
    }

    async findByUserId(query, userId: string): Promise<LanguageListDto> {
        // data access layer
        const languagesLinkEntities = (await this.dataLayer.languageLinkAll()).find(language => language.personId === userId);
        const languagesEntities = (await this.dataLayer.languageAll()).filter(language => languagesLinkEntities.languageId.includes(language.languageId));
        const languages = instanceToInstance<LanguageDto[]>(languagesEntities);
        const languagesCount = languages.length;
        return { languages, languagesCount };
    }
}
