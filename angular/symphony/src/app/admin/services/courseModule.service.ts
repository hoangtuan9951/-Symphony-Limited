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
    return this.http.get<CourseModules[]>(URI_SERVICE + "/api/admin/course-modules");
  }

  get(id: number): Observable<CourseModules> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<CourseModules>(url);
  }

  create(courseModule: any): Observable<any> {
    return this.http.post<any>(URI_SERVICE + "", courseModule);
  }

  update(courseModule: any): Observable<any> {
    const url = `${URI_SERVICE + ""}/${courseModule.id}`;
    return this.http.put<any>(url, courseModule);
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}