import { AuthService } from './auth.service';
import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot } from '@angular/router';

@Injectable({providedIn: 'root'})
export class AuthGuard implements CanActivate {
  constructor(private auth: AuthService, private router: Router) { }

  canActivate() {
    const isLogged = this.auth.isLogged();
    if (!isLogged) {
      this.router.navigate(['login']);
    }
    return isLogged;
  }
}
