import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { HomeComponent } from './home.component';
import { CarouselModule, WavesModule } from 'angular-bootstrap-md'

@NgModule({
  imports: [
    CommonModule,
    CarouselModule,
    WavesModule,

  ],
  declarations: [
    HomeComponent
  ]
})
export class HomeModule { }
