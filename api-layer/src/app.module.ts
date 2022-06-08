import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { LanguageModule } from './language/language.module';
import { MatchModule } from './match/match.module';
import { ResearchModule } from './research/research.module';
import { SiteModule } from './site/site.module';
import { SkillModule } from './skill/skill.module';
import { UserModule } from './user/user.module';

@Module({
  imports: [
    LanguageModule, 
    MatchModule, 
    ResearchModule, 
    SiteModule,
    SkillModule,
    UserModule
  ],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule { }
