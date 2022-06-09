import { IsNotEmpty, IsUUID, MaxLength } from 'class-validator';

export class GetSimilaritiesRequestDto {
    code: number;
    @MaxLength(200)
    description: string;
    remote: boolean;
    @IsUUID()
    siteId: string;
    @IsUUID()
    userId: string;
    @IsUUID()
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