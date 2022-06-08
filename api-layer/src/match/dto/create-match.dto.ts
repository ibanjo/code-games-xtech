import { IsUUID } from 'class-validator';

export class CreateMatchDto {
  @IsUUID()
  readonly researchId: string;
  @IsUUID()
  readonly recruitedId: string;
  @IsUUID()
  readonly userId: string;
}