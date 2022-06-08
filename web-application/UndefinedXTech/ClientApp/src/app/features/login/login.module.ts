import { FormsModule } from '@angular/forms';

import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatCardModule } from '@angular/material/card';
import { SharedModule } from 'src/app/shared/shared.module';
import { LoginRoutingModule } from './login-routing.module';
import { LoginComponent } from './login.component';

@NgModule({
  imports: [
    CommonModule,
    LoginRoutingModule,
    SharedModule,
    MatButtonModule,
    MatInputModule,
    MatCardModule,
    FormsModule
  ],
  exports: [],
  declarations: [
    LoginComponent
  ],
  providers: [],
})
export class LoginModule { }
