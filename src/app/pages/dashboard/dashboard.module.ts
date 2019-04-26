import { NgModule } from '@angular/core';
import { NbCardModule } from '@nebular/theme';
import { NgxEchartsModule } from 'ngx-echarts';
import { ThemeModule } from '../../@theme/theme.module';
import { ClientViewComponent } from './client-view/client-view.component';
import { DashboardComponent } from './dashboard.component';

@NgModule({
  imports: [ThemeModule, NgxEchartsModule, NbCardModule],
  declarations: [DashboardComponent, ClientViewComponent],
})
export class DashboardModule {}
