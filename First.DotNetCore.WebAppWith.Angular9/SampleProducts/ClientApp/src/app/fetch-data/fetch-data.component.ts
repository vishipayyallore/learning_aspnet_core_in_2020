import { Component, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

// const baseApiUrl = 'https://weather-forecast-service.azurewebsites.net/api/';  // Direct Web Api
// const baseApiUrl = 'https://weather-forecast-apimgw.azure-api.net/wfsapimgw/api/'; // Using API Mgt
const baseApiUrl = 'https://college-service-apimgw.azure-api.net/wfsapimgw/api/';

// With Authorization
const headersOptions = new HttpHeaders({
  'Ocp-Apim-Subscription-Key': 'YourKey'
});


@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];

  constructor(http: HttpClient) {
    http.get<WeatherForecast[]>(`${baseApiUrl}weatherforecast`, { headers: headersOptions }).subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

}

// 

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}


/*
constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
  let baseApiUrl = 'https://weather-forecast-service.azurewebsites.net/api/';
  http.get<WeatherForecast[]>( `${baseApiUrl}weatherforecast`).subscribe(result => {
    this.forecasts = result;
  }, error => console.error(error));
}
*/


