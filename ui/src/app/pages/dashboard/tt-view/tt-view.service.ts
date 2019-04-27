import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of as observableOf } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from './../../../../environments/environment.prod';
@Injectable({
  providedIn: 'root',
})
export class TtViewService {
  passengers: any[];

  passengersTableCol: any[];

  constructor(private http: HttpClient) {
    // this.passengers = [
    //   { id: 1, bogi: 'S3', bogiId: 1, seat: 1, name: 'Rahul Warma', isPresent: false },
    //   { id: 2, bogi: 'S3', bogiId: 1, seat: 2, name: 'Ram Pyare', isPresent: true },
    //   { id: 3, bogi: 'S3', bogiId: 1, seat: 3, name: 'Sweta Warma', isPresent: true },
    //   { id: 4, bogi: 'S4', bogiId: 2, seat: 1, name: 'Yugal Paraye', isPresent: true },
    //   { id: 5, bogi: 'S4', bogiId: 2, seat: 2, name: 'vaibhav Gudadhe', isPresent: true },
    //   { id: 6, bogi: 'S4', bogiId: 2, seat: 3, name: 'Sagar Charde', isPresent: false },
    // ];

    this.passengersTableCol = [
      { field: 'bogi', header: 'Coach' },
      { field: 'seat', header: 'Seat' },
      { field: 'name', header: 'Name' },
      { field: 'isPresent', header: 'Present' },
    ];
  }

  getCoachField() {
    return { field: 'bogi', header: 'Coach' };
  }

  getPassengersTableCol(): Observable<any[]> {
    return observableOf(this.passengersTableCol);
  }

  getBogiListByTrain(train): Observable<any[]> {
    const bogiList = [
      { name: 'All', code: null },
      { name: 'S3', code: '1', id: 1 },
      { name: 'S4', code: '2', id: 2 },
      { name: 'S5', code: '3', id: 3 },
    ];
    return observableOf(bogiList);
  }

  getPassengersList(selectedTrain, selectedBogi): Observable<any[]> {
    selectedBogi = selectedBogi || 0;
    const url = `${environment.apiHost}Train/GetPassengers?trainNumber=` + selectedTrain + '&bogiId=' + selectedBogi;
    return this.http.get<any>(url).pipe(
      map(data => {
        // login successful if there's a jwt token in the response
        this.passengers = data;
        return data;
      }),
    );

    return observableOf(this.passengers);
  }

  getPassengersListByBogi(trainNumber, bogiId): Observable<any[]> {
    const passengersByBogiId = this.passengers.filter(passenger => {
      if (passenger.bogiId == bogiId && passenger.trainNumber == trainNumber) return passenger;
    });

    if (!passengersByBogiId && passengersByBogiId.length) {
      this.getPassengersList(trainNumber, bogiId);
    } else {
      return observableOf(passengersByBogiId);
    }
  }

  updatePassengerData(data): Observable<any> {
    const url = `${environment.apiHost}Train/PostPassenger`;
    return this.http.post<any>(url, data).pipe(
      map(data => {
        this.passengers = data;
        return data;
      }),
    );
  }

  replacePassengerData(oldPassengerData, newPassengerName): Observable<any> {
    const url = `${environment.apiHost}Train/ReplacePassenger`;
    return this.http.post<any>(url, { PassengerModel: oldPassengerData, NewPassengerName: newPassengerName }).pipe(
      map(data => {
        return data;
      }),
    );
  }
}
