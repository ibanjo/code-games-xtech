import { LanguageListDto } from "src/language/dto/language.dto";
import { ResearchDto } from "src/research/dto/research.dto";
import { SkillListDto } from "src/skill/dto/skill.dto";

export class UserDto {
    userId: string;
    code: number;
    name: string;
    surname: string;
    site: string;
    yearsOfExperience: number;
    position: string;
    remote: boolean;
    isRecruiter: boolean;
    skills: SkillListDto;
    languages: LanguageListDto 
}

export interface UserListDto {
    research: ResearchDto,
    users: UserDto[];
    usersCount: number;
}