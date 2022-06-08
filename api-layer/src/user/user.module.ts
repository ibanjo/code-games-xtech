import { Module } from '@nestjs/common';
import { MatchService } from 'src/match/match.service';
import { ResearchService } from 'src/research/research.service';
import { UserController } from './user.controller';
import { UserService } from './user.service';

@Module({
  providers: [UserService, MatchService, ResearchService],
  controllers: [UserController]
})
export class UserModule { }
