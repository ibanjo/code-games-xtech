import { Injectable } from '@nestjs/common';
import { SkillListDto, UserSkillListDto } from './dto/skill.dto';

@Injectable()
export class SkillService {

    async findAll(query): Promise<SkillListDto> {
        // data access layer
        const skills = [
            {
                skillId: '1',
                FEBEDevops: '',
                webMobile: '',
                technology: '',
                projectRef: '',
                description: ''
            }, 
            {
                skillId: '2',
                FEBEDevops: '',
                webMobile: '',
                technology: '',
                projectRef: '',
                description: ''
            }
        ];
        const skillsCount = skills.length;
        return {skills, skillsCount};
    }

    async findByUserId(query, userId: string): Promise<UserSkillListDto> {

        // data access layer
        const skills = [
            {
                userId: userId,
                skillId: '1',
                FEBEDevops: '',
                webMobile: '',
                technology: '',
                projectRef: '',
                description: '',
                level: 1
            }, 
            {
                userId: userId,
                skillId: '2',
                FEBEDevops: '',
                webMobile: '',
                technology: '',
                projectRef: '',
                description: '',
                level: 4
            }
        ];
        const skillsCount = skills.length;
        return {skills, skillsCount};
    }
}
