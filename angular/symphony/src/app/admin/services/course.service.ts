import { HttpClient } from "@angular/common/http";
import { axiosService } from "../../service/index";
import { HEADER } from "../../user/constant";
import { Observable } from "rxjs";
import { CoursesModel } from "../../user/models/course.model";
import { CourseModel } from "../models/Course.model";
import { URI_SERVICE } from "../../user/constant/uriInfo";


export class CourseService{
    constructor(private http: HttpClient) { }

  getAll(): Observable<CourseModel[]> {
    return this.http.get<CourseModel[]>(URI_SERVICE + "/api/admin/course-modules");
  }

  get(id: number): Observable<CourseModel> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.get<CourseModel>(url);
  }

  create(data: any): Observable<any> {
    return this.http.post<any>(URI_SERVICE + "", data , {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
  }

  update(data: any): Observable<any> {
    const url = `${URI_SERVICE + ""}/${data.id}`;
    return this.http.put<any>(url, data , {headers: {[HEADER.CONTENT_TYPE]: 'multipart/form-data'}});
  }

  delete(id: number): Observable<any> {
    const url = `${URI_SERVICE + ""}/${id}`;
    return this.http.delete(url);
  }
}