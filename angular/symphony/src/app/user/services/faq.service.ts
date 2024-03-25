import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { FAQModel } from '../models/faq.model';
import { URI_SERVICE } from '../constant/uriInfo';

@Injectable({
  providedIn: 'root'
})
export class FAQService {
 
  private apiUrl = 'http://localhost:2002/api/client/faqs';

  constructor(private http: HttpClient) {}

  getFAQ(): Observable<FAQModel[]> {
    return this.http.get<FAQModel[]>(this.apiUrl).pipe(catchError(this.handleError));
  }

  private handleError(error: any): Observable<any> {
    console.error('An error occurred:', error);
    return throwError(error);
  }
}