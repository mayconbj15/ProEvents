import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent {
  public events: any;

  constructor(private httpClient: HttpClient){
    this.getEvents();
  }

  public getEvents(): any {
    this.httpClient.get('http://localhost:5289/api/events').subscribe(
      response => this.events = response,
      error => console.error(error)
    );
  }
}
