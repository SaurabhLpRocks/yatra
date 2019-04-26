import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NbAuthResult, NbAuthService } from '@nebular/auth';

@Injectable({
  providedIn: 'root',
})
export class HeaderService {
  constructor(public authService: NbAuthService, private router: Router) {}

  logout() {
    this.authService.logout('email').subscribe((result: NbAuthResult) => {
      this.router.navigate(['auth/login']);
    });
  }
}
