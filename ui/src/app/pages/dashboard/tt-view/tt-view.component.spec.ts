import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TtViewComponent } from './tt-view.component';

describe('TtViewComponent', () => {
  let component: TtViewComponent;
  let fixture: ComponentFixture<TtViewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TtViewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TtViewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
