import { Module } from '@nestjs/common';
import { DataLayerClient } from 'src/adapter/data-layer';
import { ResearchController } from './research.controller';
import { ResearchService } from './research.service';

@Module({
  providers: [ResearchService, DataLayerClient],
  controllers: [ResearchController]
})
export class ResearchModule { }
