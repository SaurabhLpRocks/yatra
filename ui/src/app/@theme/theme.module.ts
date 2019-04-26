import { CommonModule } from '@angular/common';
import { ModuleWithProviders, NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NbSecurityModule } from '@nebular/security';
import { NbAccordionModule, NbActionsModule, NbAlertModule, NbButtonModule, NbCalendarKitModule, NbCalendarModule, NbCalendarRangeModule, NbCardModule, NbChatModule, NbCheckboxModule, NbContextMenuModule, NbDatepickerModule, NbDialogModule, NbInputModule, NbLayoutModule, NbListModule, NbMenuModule, NbPopoverModule, NbProgressBarModule, NbRadioModule, NbRouteTabsetModule, NbSearchModule, NbSelectModule, NbSidebarModule, NbSpinnerModule, NbStepperModule, NbTabsetModule, NbThemeModule, NbToastrModule, NbTooltipModule, NbUserModule, NbWindowModule } from '@nebular/theme';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FooterComponent, HeaderComponent, LayoutDirectionSwitcherComponent, SearchInputComponent, SwitcherComponent, ThemeSettingsComponent, ThemeSwitcherComponent, ThemeSwitcherListComponent, TinyMCEComponent, ToggleSettingsButtonComponent } from './components';
import { OneColumnLayoutComponent, SampleLayoutComponent, ThreeColumnsLayoutComponent, TwoColumnsLayoutComponent } from './layouts';
import { CapitalizePipe, EvaIconsPipe, NumberWithCommasPipe, PluralPipe, RoundPipe, TimingPipe } from './pipes';
import { CORPORATE_THEME } from './styles/theme.corporate';
import { COSMIC_THEME } from './styles/theme.cosmic';
import { DEFAULT_THEME } from './styles/theme.default';




const BASE_MODULES = [CommonModule, FormsModule, ReactiveFormsModule];

const NB_MODULES = [
  NbCardModule,
  NbLayoutModule,
  NbTabsetModule,
  NbRouteTabsetModule,
  NbMenuModule,
  NbUserModule,
  NbActionsModule,
  NbSearchModule,
  NbSidebarModule,
  NbCheckboxModule,
  NbPopoverModule,
  NbContextMenuModule,
  NgbModule,
  NbSecurityModule, // *nbIsGranted directive,
  NbProgressBarModule,
  NbCalendarModule,
  NbCalendarRangeModule,
  NbStepperModule,
  NbButtonModule,
  NbListModule,
  NbToastrModule,
  NbInputModule,
  NbAccordionModule,
  NbDatepickerModule,
  NbDialogModule,
  NbWindowModule,
  NbAlertModule,
  NbSpinnerModule,
  NbRadioModule,
  NbSelectModule,
  NbChatModule,
  NbTooltipModule,
  NbCalendarKitModule,
];

const COMPONENTS = [
  SwitcherComponent,
  LayoutDirectionSwitcherComponent,
  ThemeSwitcherComponent,
  ThemeSwitcherListComponent,
  HeaderComponent,
  FooterComponent,
  SearchInputComponent,
  ThemeSettingsComponent,
  TinyMCEComponent,
  OneColumnLayoutComponent,
  SampleLayoutComponent,
  ThreeColumnsLayoutComponent,
  TwoColumnsLayoutComponent,
  ToggleSettingsButtonComponent,
];

const ENTRY_COMPONENTS = [
  ThemeSwitcherListComponent,
];

const PIPES = [
  CapitalizePipe,
  PluralPipe,
  RoundPipe,
  TimingPipe,
  NumberWithCommasPipe,
  EvaIconsPipe,
];

const NB_THEME_PROVIDERS = [
  ...NbThemeModule.forRoot(
    {
      name: 'corporate',
    },
    [ DEFAULT_THEME, COSMIC_THEME, CORPORATE_THEME ],
  ).providers,
  ...NbSidebarModule.forRoot().providers,
  ...NbMenuModule.forRoot().providers,
  ...NbDatepickerModule.forRoot().providers,
  ...NbDialogModule.forRoot().providers,
  ...NbWindowModule.forRoot().providers,
  ...NbToastrModule.forRoot().providers,
  ...NbChatModule.forRoot({
    messageGoogleMapKey: 'AIzaSyA_wNuCzia92MAmdLRzmqitRGvCF7wCZPY',
  }).providers,
];

@NgModule({
  imports: [...BASE_MODULES, ...NB_MODULES],
  exports: [...BASE_MODULES, ...NB_MODULES, ...COMPONENTS, ...PIPES],
  declarations: [...COMPONENTS, ...PIPES],
  entryComponents: [...ENTRY_COMPONENTS],
})
export class ThemeModule {
  static forRoot(): ModuleWithProviders {
    return <ModuleWithProviders>{
      ngModule: ThemeModule,
      providers: [...NB_THEME_PROVIDERS],
    };
  }
}
