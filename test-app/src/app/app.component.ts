import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public customerId = 0;
  public initialCredit = 0;

  public users: any[] = [];

  constructor(
    private appService: AppService,
  ) { }
  async ngOnInit() {
    await this.load();
  }
  async OpenAccount() {
    this.appService.openAccount(this.customerId, this.initialCredit).subscribe(res => { this.load(); });

  }

  load = () => {
    this.appService.getUsers().subscribe(res => {
      this.users = res;
    });
  }
}
