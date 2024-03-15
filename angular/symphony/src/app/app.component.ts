import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ROUTE_NOT_IN_LAYOUT_USER } from './user/constant';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
 
export class AppComponent {
  title: string = 'symphony';

  constructor(private activatedRoute: ActivatedRoute,private router: Router) {}


  isInAdminPage(): boolean {
    return this.activatedRoute.snapshot.firstChild?.routeConfig?.path === 'admin';
  }
  isInAuthPage(): boolean {
    return this.activatedRoute.snapshot.firstChild?.routeConfig?.path === 'auth';
  }
}
