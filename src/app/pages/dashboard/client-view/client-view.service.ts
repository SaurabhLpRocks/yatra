import { Injectable } from '@angular/core';
import { Observable, of as observableOf } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ClientViewService {
  constructor() {}

  getFakeCarData(): Observable<any[]> {
    const cars: any[] = [
      { vin: 'dsad231ff', year: 1978, brand: 'Audi', color: 'red' },
      { vin: 'dsad231f2', year: 2011, brand: 'wolkwagon', color: 'yellow' },
    ];

    return observableOf(cars);
  }
}
