export interface LanguageDto {
    languageId: string;
    code: number;
    description: string;
}

export interface LanguageListDto {
    languages: LanguageDto[];
    languagesCount: number;
}

export interface UserLanguageDto extends LanguageDto {
    userId: string;
    languageLevelCode: number;
    languageLevelDescription: string;
    preferred: boolean;    
}