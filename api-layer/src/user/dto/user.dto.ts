import { ResearchDto } from "src/research/dto/research.dto";
import { UserSkillListDto } from "src/skill/dto/skill.dto";

export class UserDto {
    userId: string;
    code: number;
    name: string;
    surname: string;
    siteId: string;
    yearsOfExperience: number;
    position: string;
    remote: boolean;
    isRecruiter: boolean;
    skills: UserSkillListDto; 
}

export interface UserListDto {
    research: ResearchDto,
    users: UserDto[];
    usersCount: number;
}