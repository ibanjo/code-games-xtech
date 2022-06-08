import { SpinnerComponent } from './components/spinner/spinner.component';
import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatTableModule } from '@angular/material/table';
import {MatProgressSpinnerModule} from '@angular/material/progress-spinner';
import { MatDialogModule } from '@angular/material/dialog';
import { PageComponent } from './components/page/page.component';

@NgModule({
  imports: [
    CommonModule,
    MatTableModule,
    MatButtonModule,
    MatButtonModule,
    MatDialogModule,
    MatProgressSpinnerModule
  ],
  declarations: [
    PageComponent,
    SpinnerComponent
  ],
  exports: [
    PageComponent,
    SpinnerComponent
  ]
})
export class SharedModule { }
