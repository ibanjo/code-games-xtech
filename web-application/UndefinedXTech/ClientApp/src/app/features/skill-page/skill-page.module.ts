
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatRadioModule } from '@angular/material/radio';
import { MatSelectModule } from '@angular/material/select';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatIconModule } from '@angular/material/icon';
import { SharedModule } from 'src/app/shared/shared.module';
import { SkillPageRoutingModule } from './skill-page-routing.module';

import { SkillPageComponent } from './skill-page.component';

@NgModule({
  imports: [
    CommonModule,
    SkillPageRoutingModule,
    SharedModule,
    MatInputModule,
    MatButtonModule,
    MatRadioModule,
    MatSelectModule,
    MatCheckboxModule,
    MatIconModule,
    ReactiveFormsModule,
    FormsModule
  ],
  exports: [],
  declarations: [
    SkillPageComponent
  ],
  providers: [],
})
export class SkillPageModule { }
