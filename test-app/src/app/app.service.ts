import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  constructor(private http: HttpClient,) { }

  public openAccount(customerId: number, initialCredit: number): Observable<any> {
    const body = new HttpParams()
      .set('customerId', customerId)
      .set('initialCredit', initialCredit);

    return this.http.post('https://localhost:5001/Users/ConnectOldAccountToNew',
      body.toString(),
      {
        headers: new HttpHeaders()
          .set('Content-Type', 'application/x-www-form-urlencoded')
      }
    );
    // return this.http.post('https://localhost:5001/Users/ConnectOldAccountToNew',
    //   { customerId, initialCredit }
    // );
  }
  public getUsers(): Observable<any> {
    const res = this.http.get('https://localhost:5001/Users/getUsers');
    return res;
  }
}
