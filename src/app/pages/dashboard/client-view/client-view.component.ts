import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { ClientViewService } from './client-view.service';

@Component({
  selector: 'ngx-client-view',
  templateUrl: './client-view.component.html',
  styleUrls: ['./client-view.component.scss'],
  providers: [ClientViewService],
  animations: [
    trigger('rowExpansionTrigger', [
      state(
        'void',
        style({
          transform: 'translateX(-10%)',
          opacity: 0,
        }),
      ),
      state(
        'active',
        style({
          transform: 'translateX(0)',
          opacity: 1,
        }),
      ),
      transition('* <=> *', animate('400ms cubic-bezier(0.86, 0, 0.07, 1)')),
    ]),
  ],
})
export class ClientViewComponent implements OnInit {
  cars: any[];

  cols: any[];
  constructor(private clientViewService: ClientViewService) {}

  ngOnInit() {
    this.clientViewService.getFakeCarData().subscribe(cars => {
      this.cars = cars;
      console.log('cars', this.cars);
    });

    this.cols = [
      { field: 'vin', header: 'Vin' },
      { field: 'year', header: 'Year' },
      { field: 'brand', header: 'Brand' },
      { field: 'color', header: 'Color' },
    ];
  }
}
