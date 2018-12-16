import { HttpClient } from "@angular/common/http";
import { Component } from "@angular/core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"]
})
export class AppComponent {
  title = "ClientApp";

  weatherContent: string = "";

  /**
   *
   */
  constructor(private http: HttpClient) {
    http
      .get("api/sampleData/WeatherForecasts")
      .subscribe(w => (this.weatherContent = JSON.stringify(w)));
  }
}
