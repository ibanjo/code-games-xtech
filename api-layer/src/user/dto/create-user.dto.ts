import { IsEmail, IsNotEmpty, IsUUID } from 'class-validator';

export class CreateUserDto {
  readonly code: number;
  @IsNotEmpty()
  readonly name: string;
  @IsNotEmpty()
  readonly surname: string;
  @IsUUID()
  readonly siteId: string;
  readonly yearsOfExperience: number;
  @IsNotEmpty()
  readonly position: string;
  readonly remote: boolean;
  readonly isRecruiter: boolean;
}