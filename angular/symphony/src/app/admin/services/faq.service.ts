import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { URI_SERVICE } from '../../user/constant/uriInfo';
import { FAQModel } from '../models/FAQ.model';

@Injectable({
  providedIn: 'root'
})
export class FAQService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<FAQModel[]> {
    return this.http.get<FAQModel[]>(URI_SERVICE);
  }

  get(id: number): Observable<FAQModel> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<FAQModel>(url);
  }

  create(courseModule: FAQModel): Observable<FAQModel> {
    return this.http.post<FAQModel>(URI_SERVICE + "", courseModule);
  }

  update(courseModule: FAQModel): Observable<FAQModel> {
    const url = `${URI_SERVICE + ""}/${courseModule.id}`;
    return this.http.put<FAQModel>(url, courseModule);
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}