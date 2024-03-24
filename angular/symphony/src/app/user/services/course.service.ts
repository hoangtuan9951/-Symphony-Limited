// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CourseModuleMenuModel, CoursesModel } from '../models/course.model';
import { URI_SERVICE } from '../constant/uriInfo';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private http: HttpClient) { }

  
  getMenuCourseData(): Observable<CourseModuleMenuModel[]> {
    return this.http.get<CourseModuleMenuModel[]>(URI_SERVICE+ "");
  }
  getTopSixCousse():Observable<CoursesModel[]> {
    return this.http.get<CoursesModel[]>(URI_SERVICE + "");
  }
}
