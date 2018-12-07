import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  public personal: PersonalBBP[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<PersonalBBP[]>(baseUrl + 'api/SampleData/GetPersonalBBP').subscribe(result => {
      this.personal = result;
    }, error => console.error(error));
  }
  //constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  //  http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
  //    this.forecasts = result;
  //  }, error => console.error(error));
  //}
}


interface PersonalBBP {
  nombre: string;
  app: string;
  apm: string;
  sexo: string;
  puesto: string;
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
