import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { AddPassengerDialogComponent } from './add-passenger-dialog.component';

describe('AddPassengerDialogComponent', () => {
  let component: AddPassengerDialogComponent;
  let fixture: ComponentFixture<AddPassengerDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AddPassengerDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(AddPassengerDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
