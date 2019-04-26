import { Component, Input, OnInit } from '@angular/core';
import { NbMenuService, NbSidebarService } from '@nebular/theme';
import { filter, map } from 'rxjs/operators';
import { UserData } from '../../../@core/data/users';
import { AnalyticsService, LayoutService } from '../../../@core/utils';
import { HeaderService } from './header.service';

@Component({
  selector: 'ngx-header',
  styleUrls: ['./header.component.scss'],
  templateUrl: './header.component.html',
  providers: [HeaderService],
})
export class HeaderComponent implements OnInit {
  @Input() position = 'normal';

  user: any;

  userMenu = [{ title: 'Profile' }, { title: 'Log out' }];

  constructor(
    private sidebarService: NbSidebarService,
    private menuService: NbMenuService,
    private userService: UserData,
    private analyticsService: AnalyticsService,
    private layoutService: LayoutService,
    private headerService: HeaderService,
  ) {}

  ngOnInit() {
    // this.userService.getUsers()
    //   .subscribe((users: any) => this.user = users.nick);
    this.menuService
      .onItemClick()
      .pipe(
        filter(({ tag }) => tag === 'user-context-menu'),
        map(({ item: { title } }) => title),
      )
      .subscribe(title => {
        this.userContextMenuClick(title);
      });
  }

  userContextMenuClick(menuTitle: string) {
    switch (menuTitle) {
      case this.userMenu[1].title:
        this.logout();
        break;

      default:
        break;
    }
  }

  toggleSidebar(): boolean {
    this.sidebarService.toggle(true, 'menu-sidebar');
    this.layoutService.changeLayoutSize();

    return false;
  }

  goToHome() {
    this.menuService.navigateHome();
  }

  startSearch() {
    this.analyticsService.trackEvent('startSearch');
  }

  logout() {
    this.headerService.logout();
  }
}
