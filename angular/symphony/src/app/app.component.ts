import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ROUTE_IN_LAYOUT_ADMIN, ROUTE_NOT_IN_LAYOUT_USER } from './constant';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
 
export class AppComponent {
  title: string = 'symphony';

  constructor(private router: Router) {
    
  }

  isChildrenAdmin(): boolean {
    return ROUTE_IN_LAYOUT_ADMIN.some(path => this.router.url.startsWith(path));
  }


  isInAdminPage(): boolean {
    return ROUTE_NOT_IN_LAYOUT_USER.some(path => this.router.url.startsWith(path));
  }
}
