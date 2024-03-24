import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { URI_SERVICE } from '../../user/constant/uriInfo';
import { FAQModel } from '../models/FAQ.model';
import { StudentModel } from '../models/Student.model';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<StudentModel[]> {
    return this.http.get<StudentModel[]>(URI_SERVICE);
  }

  get(id: number): Observable<StudentModel> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<StudentModel>(url);
  }

  create(courseModule: FAQModel): Observable<StudentModel> {
    return this.http.post<StudentModel>(URI_SERVICE + "", courseModule);
  }

  update(courseModule: FAQModel): Observable<StudentModel> {
    const url = `${URI_SERVICE + ""}/${courseModule.id}`;
    return this.http.put<StudentModel>(url, courseModule);
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}