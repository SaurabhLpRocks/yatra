import { Component, OnDestroy } from '@angular/core';
import { NbAuthJWTToken, NbAuthService } from '@nebular/auth';

@Component({
  selector: 'ngx-dashboard',
  styleUrls: ['./dashboard.component.scss'],
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent implements OnDestroy {
  user = {};
  constructor(private authService: NbAuthService) {
    this.authService.onTokenChange().subscribe((token: NbAuthJWTToken) => {
      if (token.isValid()) {
        this.user = token.getPayload();
        console.log('this.user', this.user);
      }
    });
  }

  ngOnDestroy() {}
}
