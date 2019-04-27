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
  isDataPresent: boolean = false;
  selectedStartPoint: { name: string; code: string };
  selectedEndPoint: { name: string; code: string };
  trainProbabilityDetails: any[];
  cols: any[];
  trainPredictionClassCol: any[];
  constructor(private clientViewService: ClientViewService) {}

  stations: any[];

  showStartStationError: boolean = false;

  showEndStationError: boolean = false;

  bothStationSameError: boolean = false;

  ngOnInit() {
    // this.clientViewService
    //   .getTrainProbabilityData()
    //   .pipe(first())
    //   .subscribe(classDetails => {
    //     this.trainProbabilityDetails = classDetails;
    //     console.log('trainProbabilityDetails', this.trainProbabilityDetails);
    //   });

    this.cols = [{ field: 'trainNumber', header: 'Train' }, { field: 'name', header: 'Name' }];

    this.trainPredictionClassCol = [{ field: 'class', header: 'Class' }, { field: 'accuracy', header: 'Probability (%)' }];

    this.clientViewService
      .getStationsList()
      .pipe()
      .subscribe(data => {
        this.stations = data;
      });
  }

  tableRowClick(train) {
    this.clientViewService.sendUserTrainSelectionStatus(train, 'User').subscribe(x => {});
    // console.log('Clicked', train);
  }

  handleClick(event) {
    this.showStartStationError = this.showEndStationError = this.bothStationSameError = false;
    if (!this.selectedStartPoint || !this.selectedStartPoint.code) {
      this.showStartStationError = true;
    }

    if (!this.selectedEndPoint || !this.selectedEndPoint.code) {
      this.showEndStationError = true;
    }

    if (this.showStartStationError || this.showEndStationError) {
      return false;
    }

    if (this.selectedStartPoint == this.selectedEndPoint) {
      this.bothStationSameError = true;
      return false;
    }

    this.clientViewService
      .getTrainProbabilityData(this.selectedStartPoint.name, this.selectedEndPoint.name)
      .pipe(first())
      .subscribe(classDetails => {
        this.isDataPresent = true;
        this.trainProbabilityDetails = classDetails;
        console.log('trainProbabilityDetails', this.trainProbabilityDetails);
      });
  }
}
