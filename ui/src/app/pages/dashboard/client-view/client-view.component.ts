import { animate, state, style, transition, trigger } from '@angular/animations';
import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs/operators';
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
  trainProbabilityDetails: any[];
  cols: any[];
  trainPredictionClassCol: any[];
  constructor(private clientViewService: ClientViewService) {}

  ngOnInit() {
    this.clientViewService
      .getTrainProbabilityData()
      .pipe(first())
      .subscribe(classDetails => {
        this.trainProbabilityDetails = classDetails;
        console.log('trainProbabilityDetails', this.trainProbabilityDetails);
      });

    this.cols = [{ field: 'trainNumber', header: 'Train' }, { field: 'name', header: 'Name' }];

    this.trainPredictionClassCol = [{ field: 'class', header: 'Class' }, { field: 'accuracy', header: 'Accuracy' }];
  }

  tableRowClick(train) {
    console.log('Clicked', train);
  }
}
