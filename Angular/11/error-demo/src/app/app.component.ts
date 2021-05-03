import { Component } from '@angular/core';
import { ApiService } from './api.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  title(title: any) {
    throw new Error('Method not implemented.');
  }
  constructor(private _service: ApiService) {}

  fetch() {
    this._service.fetchData().subscribe(
      (data) => console.log(data),
      (error) => console.log(error),
      () => console.log('Done')
    );
  }
}
