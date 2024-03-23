// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CourseModuleMenuModel } from '../models/course.model';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private apiURI = '';

  constructor(private http: HttpClient) { }

  
  getMenuCourseData(): Observable<CourseModuleMenuModel[]> {
    return this.http.get<CourseModuleMenuModel[]>(this.apiURI + "");
  }
}
