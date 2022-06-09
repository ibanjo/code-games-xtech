import { IsNotEmpty, IsUUID } from 'class-validator';

export class GetSimilaritiesRequestDto {
    //@IsUUID()
    researchID: string;
    languageID: string;
    languageLevel: number;
    @IsNotEmpty()
    FEBEDevops: string;
    @IsNotEmpty()
    webMobile: string;
    @IsNotEmpty()
    technology: string;
    level: number;
}