import { Injectable } from '@nestjs/common';
import { instanceToInstance } from 'class-transformer';
import { DataLayerClient } from 'src/adapter/data-layer';
import { SkillDto, SkillListDto } from './dto/skill.dto';

@Injectable()
export class SkillService {
    constructor(private readonly dataLayer: DataLayerClient) { }

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
        return { skills, skillsCount };
    }

    async findByUserId(userId: string): Promise<SkillListDto> {
        const allSkills = await this.dataLayer.skillAll();
        // data access layer
        const skillLinks = (await this.dataLayer.skillLinkAll()).filter(x => userId.toLowerCase() === x.personId.toLowerCase()).map(s => s.skillId);
        const skills = allSkills.filter(s => skillLinks.includes(s.skillId)).map(s => ({
            skillId: s.skillId,
            FEBEDevops: s.febeDevops,
            webMobile: s.webMobile,
            technology: s.technology,
            projectRef: s.projectRef,
            description: s.description
        } as SkillDto));
        const skillsCount = skills.length;
        return { skills, skillsCount };
    }
}
