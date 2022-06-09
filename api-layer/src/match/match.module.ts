import { Module } from '@nestjs/common';
import { DataLayerClient } from 'src/adapter/data-layer';
import { MatchController } from './match.controller';
import { MatchService } from './match.service';

@Module({
  providers: [MatchService, DataLayerClient],
  controllers: [MatchController]
})
export class MatchModule { }