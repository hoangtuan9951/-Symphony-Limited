import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CourseModules } from '../models/CourseModule.model';
import { URI_SERVICE } from '../../user/constant/uriInfo';

@Injectable({
  providedIn: 'root'
})
export class CourseModulesService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<CourseModules[]> {
    return this.http.get<CourseModules[]>(URI_SERVICE);
  }

  get(id: number): Observable<CourseModules> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<CourseModules>(url);
  }

  create(courseModule: CourseModules): Observable<CourseModules> {
    return this.http.post<CourseModules>(URI_SERVICE + "", courseModule);
  }

  update(courseModule: CourseModules): Observable<CourseModules> {
    const url = `${URI_SERVICE + ""}/${courseModule.id}`;
    return this.http.put<CourseModules>(url, courseModule);
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}