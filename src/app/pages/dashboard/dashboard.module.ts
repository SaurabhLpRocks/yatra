import { NgModule } from '@angular/core';
import { NbCardModule } from '@nebular/theme';
import { NgxEchartsModule } from 'ngx-echarts';
import { ThemeModule } from '../../@theme/theme.module';
import { DashboardComponent } from './dashboard.component';
import { WeatherComponent } from './weather/weather.component';

@NgModule({
  imports: [ThemeModule, NgxEchartsModule, NbCardModule],
  declarations: [DashboardComponent, WeatherComponent],
})
export class DashboardModule {}
