import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { FAQModel } from '../models/faq.model';
import { URI_SERVICE } from '../constant/uriInfo';

@Injectable({
  providedIn: 'root'
})
export class FAQService {
 
  constructor(private http: HttpClient) { }

  getAllListData(): Observable<any> {
    return this.http.get<{ success: boolean, total: number, data: FAQModel[] }>(URI_SERVICE +  '/v1/api/application/faqs');
  }
}