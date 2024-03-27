// home.component.ts

import { Component } from '@angular/core';
import { CourseService } from '../../../services/course.service';
import { ContactModel } from '../../../models/contact.model';

@Component({
  selector: 'app-footer-user',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.scss']
})
export class FooterComponent {
  title = 'my-app';
  contact: ContactModel | undefined ;
  constructor(
    private courseService: CourseService  ) {}
  ngOnInit(): void {
    this.courseService.getFooter().subscribe((response) => {
      if(response.length > 0)
      this.contact = response[0];
      });
  }

}

