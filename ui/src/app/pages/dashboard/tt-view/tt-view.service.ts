import { Injectable } from '@angular/core';
import { Observable, of as observableOf } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class TtViewService {

  passengers : any[];

  passengersTableCol : any[];

  constructor() {
    this.passengers  = [
      { id:1, bogiId:1, seat : 1, name : "Rahul Warma", isPresent : true},
      { id:2, bogiId:1, seat : 2, name : "Ram Pyare",isPresent : true},
      { id:3, bogiId:1, seat : 3, name : "Sweta Warma", isPresent : true},
      { id:4, bogiId:2, seat : 1, name : "Yugal Paraye", isPresent : true},
      { id:5, bogiId:2, seat : 2, name : "vaibhav Gudadhe", isPresent : true},
      { id:6, bogiId:2, seat : 3, name : "Sagar Charde", isPresent : true}
    ];

    this.passengersTableCol = [
      { field: 'seat', header: 'Seat' },
      { field: 'name', header: 'Name' },
      { field: 'isPresent', header: 'Present' },
    ];
   }

   getPassengersTableCol() : Observable<any[]>  {   
    return observableOf(this.passengersTableCol);
  }


getBogiListByTrain(train) : Observable<any[]>{
    const bogiList =  [
      {name: 'All', code: null},
      {name: 'S3', code: '1', id:1},
      {name: 'S4', code: '2', id:2}
  ];
  return observableOf(bogiList);
}

  getPassengersList() : Observable<any[]>  {   
    return observableOf(this.passengers);
  }

  getPassengersListByBogi(bogiId) : Observable<any[]>  {  
    const passengersByBogiId=   this.passengers.filter(passenger => {
          if(passenger.bogiId == bogiId) return passenger;
      })
    return observableOf(passengersByBogiId);
  }
}
