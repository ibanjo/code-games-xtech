
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { SharedModule } from 'src/app/shared/shared.module';
import { SearchRoutingModule } from './search-routing.module';

import { SearchComponent } from './search.component';

@NgModule({
  imports: [
    CommonModule,
    SearchRoutingModule,
    SharedModule
  ],
  exports: [],
  declarations: [
    SearchComponent
  ],
  providers: [],
})
export class SearchModule { }
