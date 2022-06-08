import { Module } from '@nestjs/common';
import { ResearchController } from './research.controller';
import { ResearchService } from './research.service';

@Module({
  providers: [ResearchService],
  controllers: [ResearchController]
})
export class ResearchModule { }
