import { AuthService } from './../../core/auth.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
})
export class LoginComponent {

  loading = false;

  constructor(private auth: AuthService) {}

  login(formValue: any) {
    this.loading = true;
    this.auth.login(formValue.username, formValue.password)
  }

}
