import { Component, OnInit } from '@angular/core';
import { TtViewService } from './tt-view.service';

@Component({
  selector: 'ngx-tt-view',
  templateUrl: './tt-view.component.html',
  styleUrls: ['./tt-view.component.scss'],
  providers: [TtViewService],
})
export class TtViewComponent implements OnInit {
  selectedBogi: { name: string; code: string };
  bogiList: any[];
  passengers: any[];
  passengersTableCol: any[];
  selectedTrain: number = 1234;
  constructor(private TtViewService: TtViewService) {}

  ngOnInit() {
    this.TtViewService.getBogiListByTrain(this.selectedTrain).subscribe(bogiList => {
      this.bogiList = bogiList;
      console.log('Bogi List ', bogiList);
    });

    this.setPassengersList();

    this.TtViewService.getPassengersTableCol().subscribe(tableCol => {
      this.passengersTableCol = tableCol;
      console.log(this.passengersTableCol);
    });
  }

  setPassengersList() {
    this.TtViewService.getPassengersList().subscribe(passengers => {
      this.passengers = passengers;
      console.log('Passengers List : ', this.passengers);
    });
  }

  bogiSelected(value) {
    console.log('DD chanege  ', value);

    if (value && value.id) {
      this.TtViewService.getPassengersListByBogi(value.id).subscribe(passengers => {
        this.passengers = passengers;
        console.log('bogiSelected : ', this.passengers);
      });
    } else {
      console.log('bogiSelected : ', this.passengers);
      this.setPassengersList();
    }
  }

  togglePassengerPresence(e, row) {
    row.isPresent = e;
  }
}
