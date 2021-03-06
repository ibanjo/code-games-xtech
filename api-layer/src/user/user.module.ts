import { Module } from '@nestjs/common';
import { DataLayerClient } from 'src/adapter/data-layer';
import { MLLayerClient } from 'src/adapter/ml-layer';
import { MatchService } from 'src/match/match.service';
import { ResearchService } from 'src/research/research.service';
import { UserController } from './user.controller';
import { UserService } from './user.service';

@Module({
  providers: [UserService, MatchService, ResearchService, DataLayerClient, MLLayerClient],
  controllers: [UserController]
})
export class UserModule { }
