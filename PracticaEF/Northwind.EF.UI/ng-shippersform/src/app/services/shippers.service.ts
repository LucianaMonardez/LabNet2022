import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Shipper } from '../models/shippers';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  endpoint: string = 'shippers';
  constructor(private http: HttpClient) { }

  public createShipper(shippersRequest: Shipper): Observable<any> {
    let url = environment.apiShippers + this.endpoint;
    return this.http.post(url, shippersRequest)
  }

  public getShippers(): Observable<Array<Shipper>> {
    let url = environment.apiShippers + this.endpoint;
    return this.http.get<Array<Shipper>>(url);
  }

  public updateShipper(shippersRequest: Shipper): Observable<any> {
    let url = environment.apiShippers + this.endpoint + '/' + shippersRequest.ShipperID;
    return this.http.put(url, shippersRequest);
  }

  public deleteShipper(id: Number): Observable<Shipper> {
    let url = environment.apiShippers + this.endpoint + '/' + id;
    return this.http.delete<Shipper>(url);
  }
}
