import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { category } from '../models/category.model';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  BASE_URL = 'http://localhost:5160/api/Category';
 
  http: HttpClient = inject(HttpClient);
  constructor() { }

  getAll(): Observable<category[]>{
    return this.http.get<category[]>(this.BASE_URL);
  }

  getById(id: number): Observable<category>{
    return this.http.get<category>(this.BASE_URL + '/' + id);
  }

  update(item : category): Observable<category> {
    return this.http.put<category>(this.BASE_URL + '/' + item.id, item);
  }

  add(item: category): Observable<category>{
    return this.http.post<category>(this.BASE_URL, item);
  }

  delete(id: number){
    // let params: HttpParams = new HttpParams();
    // params.set('id', id.toString());
    // return this.http.delete(this.BASE_URL, { observe: 'events', params: params});
    return this.http.delete(this.BASE_URL + '/' + id);
  }
}
