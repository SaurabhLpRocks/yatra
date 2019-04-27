import { Component, OnInit } from '@angular/core';
import { NbDialogService } from '@nebular/theme';
import { AddPassengerDialogComponent } from './add-passenger-dialog/add-passenger-dialog.component';
import { TtViewService } from './tt-view.service';

@Component({
  selector: 'ngx-tt-view',
  templateUrl: './tt-view.component.html',
  styleUrls: ['./tt-view.component.scss'],
  providers: [TtViewService],
})
export class TtViewComponent implements OnInit {
  names: string[] = [];

  selectedBogi: { name: string; code: string };
  bogiList: any[];
  passengers: any[];
  passengersTableCol: any[];
  selectedTrain: number = 12345;

  selectedBogiId: 0;
  constructor(private TtViewService: TtViewService, private dialogService: NbDialogService) {}

  ngOnInit() {
    this.TtViewService.getBogiListByTrain(this.selectedTrain).subscribe(bogiList => {
      this.bogiList = bogiList;
      console.log('Bogi List ', bogiList);
    });

    this.setPassengersList(this.selectedTrain, this.selectedBogiId);

    this.setPassengersTableCol();
  }

  setPassengersTableCol() {
    this.TtViewService.getPassengersTableCol().subscribe(tableCol => {
      this.passengersTableCol = tableCol;

      // if(!this.selectedBogi || !this.selectedBogi.code){
      //   this.passengersTableCol.splice(0,0, this.TtViewService.getCoachField());
      // }

      console.log(this.passengersTableCol);
    });
  }
  setPassengersList(selectedTrain, selectedBogi) {
    this.TtViewService.getPassengersList(selectedTrain, selectedBogi).subscribe(passengers => {
      this.passengers = passengers;
      console.log('Passengers List : ', this.passengers);
    });
  }

  bogiSelected(value) {
    console.log('DD chanege  ', value);

    this.selectedBogiId = value.id;

    this.setPassengersList(this.selectedTrain, value.id);
  }

  togglePassengerPresence(e, row) {
    row.isPresent = e;
    console.log(e);
    this.TtViewService.updatePassengerData(row).subscribe(x => {
      console.log(x);
    });
  }

  addPassenger(passenger) {
    const oldPassengerIndex = this.passengers.indexOf(passenger);

    this.dialogService.open(AddPassengerDialogComponent).onClose.subscribe(name => {
      name && this.names.push(name);

      this.TtViewService.replacePassengerData(passenger, name).subscribe(x => {
       passenger.isReplaced = true;

        this.passengers.splice(oldPassengerIndex + 1, 0, x);
      });
    });
    console.log(passenger);
  }
}
