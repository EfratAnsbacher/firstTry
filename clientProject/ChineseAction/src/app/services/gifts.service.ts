import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { gift } from '../models/gift.model';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})

export class giftsService {

  BASE_URL = 'http://localhost:5160/api/Gift';
 
  http: HttpClient = inject(HttpClient);
  constructor() { }

  getAll(): Observable<gift[]>{
    return this.http.get<gift[]>(this.BASE_URL);
  }

  getById(id: number): Observable<gift>{
    return this.http.get<gift>(this.BASE_URL + '/' + id);
  }

  update(item : gift): Observable<gift> {
    return this.http.put<gift>(this.BASE_URL + '/' + item.id, item);
  }

  add(item: gift): Observable<gift>{
    return this.http.post<gift>(this.BASE_URL, item);
  }

  delete(id: number){
    // let params: HttpParams = new HttpParams();
    // params.set('id', id.toString());
    // return this.http.delete(this.BASE_URL, { observe: 'events', params: params});
    return this.http.delete(this.BASE_URL + '/' + id);
  }
}
