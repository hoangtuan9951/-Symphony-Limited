import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title: string = 'symphony';

  constructor(private router: Router) {
    
  }


  isInAdminPage(): boolean {
    return this.router.url.startsWith('/admin');
  }
}
