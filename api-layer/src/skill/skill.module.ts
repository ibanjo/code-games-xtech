import { Module } from '@nestjs/common';
import { DataLayerClient } from 'src/adapter/data-layer';
import { SkillController } from './skill.controller';
import { SkillService } from './skill.service';

@Module({
  providers: [SkillService, DataLayerClient],
  controllers: [SkillController]
})
export class SkillModule { }
