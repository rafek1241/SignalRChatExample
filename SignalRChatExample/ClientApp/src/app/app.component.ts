import { Component, OnInit } from "@angular/core";
import * as signalR from "@aspnet/signalr";
import * as moment from "moment";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
  styleUrls: ["./app.component.scss"]
})
export class AppComponent implements OnInit {
  chatHubConnection: any;
  messages: any[];
  message = "";

  constructor() {
    this.chatHubConnection = new signalR.HubConnectionBuilder()
      .withUrl("/hub/chat")
      .build();
  }

  ngOnInit(): void {
    this.chatHubConnection.start().catch((err: any) => console.log(err));
    this.handleMessageReceivedEvent(this.chatHubConnection);
  }

  private handleMessageReceivedEvent(connection) {
    connection.on("messageReceived", (username: string, message: string) => {
      this.messages.push({
        content: message,
        user: username,
        date: moment()
      });
    });
  }

  public sendMessageIfEnterPressed(event) {
    this.sendMessage(this.message);
  }

  sendMessage(message: string): any {
    return this.chatHubConnection
      .send("newMessage", "User1", message)
      .then(function(response) {
        this.message = "";
      });
  }
}
