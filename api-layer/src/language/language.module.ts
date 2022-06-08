import { Module } from '@nestjs/common';
import { DataLayerClient } from 'src/adapter/data-layer';
import { LanguageController } from './language.controller';
import { LanguageService } from './language.service';

@Module({
  providers: [LanguageService, DataLayerClient],
  controllers: [LanguageController]
})
export class LanguageModule { }
