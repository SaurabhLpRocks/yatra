import { Injectable } from '@angular/core';
import { Observable, of as observableOf } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ClientViewService {
  constructor() {}
  getTrainProbabilityData(): Observable<any[]> {
    const trainsProbabilityDetails: any[] =   [
      {
        train : 12345,
        name : "Gitanjali",
        prediction : [{ class : "sleeper", accuracy : 20}, { class : "AC2", accuracy : 50}, { class : "AC3", accuracy : 100}]
      },
      {
        train : 5678,
        name : "ABC",
        prediction : [{ class : "sleeper", accuracy : 10}, { class : "AC2", accuracy : 50}]
      }
    ]
    return observableOf(trainsProbabilityDetails);
  }
}
