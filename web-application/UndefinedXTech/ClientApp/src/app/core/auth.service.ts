import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { environment } from 'src/environments/environment';
import { Auth } from '../api/xvision-dto';

@Injectable({providedIn: 'root'})
export class AuthService {

  data: Auth;

  constructor(private http: HttpClient, private router: Router) {}

  login(username: string, password: string) {
    const params = new HttpParams().set('user', username).set('password', password);

    this.http.get<Auth>(`${environment.apiBaseUrl}/login`, { params }).subscribe(res => {
      this.data = res;
      this.router.navigate(['home']);
    })
  }

  logout() {
    this.data = null;
    this.router.navigate(['login']);
  }

  isLogged() {
    return !!this.data?.token;
  }
}
