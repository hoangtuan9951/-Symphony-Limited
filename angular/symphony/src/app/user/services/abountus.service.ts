import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, catchError, throwError } from 'rxjs';
import { AboutUs } from '../models/abountus.model';

@Injectable({
  providedIn: 'root',
})
export class AboutUsService {
  private apiUrl = 'http://localhost:2002/api/client/abouts';

  constructor(private http: HttpClient) {}

  get(): Observable<AboutUs[]> {
    return this.http.get<AboutUs[]>(this.apiUrl).pipe(catchError(this.handleError));
  }

  private handleError(error: any): Observable<any> {
    console.error('An error occurred:', error);
    return throwError(error);
  }
}
