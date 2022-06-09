import { IsUUID, MaxLength } from 'class-validator';

export class CreateResearchDto {
  readonly code: number;
  @MaxLength(200)
  readonly description: string;
  readonly remote: boolean;
  // @IsUUID()
  readonly siteId: string;
  // @IsUUID()
  readonly userId: string;
  // @IsUUID()
  readonly languageID: string;
}