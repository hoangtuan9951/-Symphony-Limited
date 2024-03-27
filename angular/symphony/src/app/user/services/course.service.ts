// data.service.ts

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CourseModuleMenuModel, CoursesModel } from '../models/course.model';
import { URI_SERVICE } from '../constant/uriInfo';
import { ContactModel } from '../models/contact.model';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private http: HttpClient) { }

  
  getMenuCourseData(): Observable<CourseModuleMenuModel[]> {
    return this.http.get<CourseModuleMenuModel[]>(URI_SERVICE+ "/api/client/courses");
  }
  getTopSixCousse():Observable<CoursesModel[]> {
    return this.http.get<CoursesModel[]>(URI_SERVICE + "/api/client/courses/latest-course");
  }
  getFooter():Observable<ContactModel[]>{
    return this.http.get<ContactModel[]>(URI_SERVICE + "/api/client/contacts");
  }
}
