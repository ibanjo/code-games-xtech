
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';
import { SharedModule } from 'src/app/shared/shared.module';
import { SearchResultRoutingModule } from './search-result-routing.module';
import { SearchResultComponent } from './search-result.component';
import { SkillLevelPipe } from './level.pipe';

@NgModule({
  imports: [
    CommonModule,
    SearchResultRoutingModule,
    SharedModule,
    MatButtonModule,
    MatIconModule,
    MatCardModule
  ],
  exports: [],
  declarations: [
    SearchResultComponent,
    SkillLevelPipe
  ],
  providers: [],
})
export class SearchResultModule { }
