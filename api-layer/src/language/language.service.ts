import { Injectable } from '@nestjs/common';
import { LanguageListDto } from './dto/language.dto';

@Injectable()
export class LanguageService {
    async findAll(): Promise<LanguageListDto> {
        // data access layer
        const languages = [
            {
                languageId: '1',
                code: 1,
                description: ''
            },
            {
                languageId: '2',
                code: 1,
                description: ''
            }
        ];
        const languagesCount = languages.length;
        return { languages, languagesCount };
    }

    async findByUserId(query, userId: string): Promise<LanguageListDto> {
        // data access layer
        const languages = [
            {
                languageId: '1',
                code: 1,
                description: '',
                userId: '1',
                languageLevelCode: 'C1',
                languageLevelDescription: 'C1',
                preferred: true
            },
            {
                languageId: '2',
                code: 1,
                description: '',
                userId: '1',
                languageLevelCode: 'B1',
                languageLevelDescription: 'B1',
                preferred: false
            }
        ];
        const languagesCount = languages.length;
        return { languages, languagesCount };
    }
}
