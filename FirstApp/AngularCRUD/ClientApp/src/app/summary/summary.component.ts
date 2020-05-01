import { Component } from '@angular/core';

@Component({
  selector: 'app-summary',
  templateUrl: './summary.component.html'
})
export class SummaryComponent {
  Name : string = 'abc';

  changeName() {
    this.Name = 'SHashnak';
  }
}
