import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { environment } from './../../../../environments/environment.prod';

@Injectable({
  providedIn: 'root',
})
export class ClientViewService {
  constructor(private http: HttpClient) {}
  getTrainProbabilityData(startStation: string, endStation: string): Observable<any[]> {
    const url = `${environment.apiHost}/Train?from=` + startStation + '&to=' + endStation;
    return this.http.get<any>(url).pipe(
      map(data => {
        // login successful if there's a jwt token in the response
        return data;
      }),
    );
  }

  getStationsList(): Observable<any[]> {
    return this.http.get<any>(`${environment.apiHost}/Train/GetCities`).pipe(
      map(data => {
        // login successful if there's a jwt token in the response
        return data;
      }),
    );
  }
}
