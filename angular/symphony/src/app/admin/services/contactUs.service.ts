import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { URI_SERVICE } from '../../user/constant/uriInfo';
import { ContactUsModel } from '../models/ContactUs.model';

@Injectable({
  providedIn: 'root'
})
export class ContactUsService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<ContactUsModel[]> {
    return this.http.get<ContactUsModel[]>(URI_SERVICE);
  }

  get(id: number): Observable<ContactUsModel> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<ContactUsModel>(url);
  }

  create(courseModule: ContactUsModel): Observable<ContactUsModel> {
    return this.http.post<ContactUsModel>(URI_SERVICE + "", courseModule);
  }

  update(courseModule: ContactUsModel): Observable<ContactUsModel> {
    const url = `${URI_SERVICE + ""}/${courseModule.id}`;
    return this.http.put<ContactUsModel>(url, courseModule);
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}