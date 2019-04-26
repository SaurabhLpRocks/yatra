import { Component, OnInit } from '@angular/core';
import { TtViewService } from './tt-view.service';
import {SelectItem} from 'primeng/api';
// import {DropdownModule} from 'primeng/dropdown';

@Component({
  selector: 'ngx-tt-view',
  templateUrl: './tt-view.component.html',
  styleUrls: ['./tt-view.component.scss'],
  providers: [ TtViewService ]
})


// interface City {
//   name: string;
//   code: string;
// }



export class TtViewComponent implements OnInit {

  selectedBogi: {name: string; code: string;};
  bogiList :  any[];
 passengers : any[];
 passengersTableCol : any[];
 selectedTrain : number = 1234;
  constructor(private TtViewService : TtViewService) { }

  ngOnInit() {

    this.TtViewService.getBogiListByTrain(this.selectedTrain).subscribe(bogiList => {
        this.bogiList = bogiList;
        console.log("Bogi List ", bogiList); 
    })

   this.TtViewService.getPassengersList().subscribe(passengers => {
      this.passengers = passengers;   
      console.log("Passengers List : ", this.passengers);
   })

   this.TtViewService.getPassengersTableCol().subscribe(tableCol => {
        this.passengersTableCol = tableCol;
        console.log(this.passengersTableCol );
   })
  }

  bogiSelected(value){
     console.log("DD chanege  " , value);

      if(value && value.id){
        this.TtViewService.getPassengersListByBogi(value.id).subscribe(passengers => {
          this.passengers = passengers;   
          console.log("bogiSelected : ", this.passengers);
        })
      }

      }

}
