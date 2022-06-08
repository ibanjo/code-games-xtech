export class SkillDto {
    skillId: string;
    FEBEDevops: string;
    webMobile: string;
    technology: string;
    projectRef: string;
    description: string;
}

export class UserSkillDto extends SkillDto {
    userId: string;
    level: number;
}

export interface SkillListDto {
    skills: SkillDto[];
    skillsCount: number;
}

export interface UserSkillListDto {
    skills: UserSkillDto[];
    skillsCount: number;
}