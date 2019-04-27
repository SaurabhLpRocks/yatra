import { Component } from '@angular/core';
import { NbDialogRef } from '@nebular/theme';

@Component({
  selector: 'ngx-add-passenger-dialog',
  templateUrl: './add-passenger-dialog.component.html',
  styleUrls: ['./add-passenger-dialog.component.scss'],
})
export class AddPassengerDialogComponent {
  constructor(protected ref: NbDialogRef<AddPassengerDialogComponent>) {}

  cancel() {
    this.ref.close();
  }

  submit(name) {
    this.ref.close(name);
  }
}
