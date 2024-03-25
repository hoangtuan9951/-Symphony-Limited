import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { URI_SERVICE } from '../constant/uriInfo';
import { Contact } from '../models/contactus.model';

@Injectable({
  providedIn: 'root',
})
export class ContactUsService {
  private apiUrl = 'http://localhost:2002/api/client/contacts';

  constructor(private http: HttpClient) {}

  getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>(this.apiUrl).pipe(catchError(this.handleError));
  }

  private handleError(error: any): Observable<any> {
    console.error('An error occurred:', error);
    return throwError(error);
  }
}
