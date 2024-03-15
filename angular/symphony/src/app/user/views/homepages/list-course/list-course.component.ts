import { Component } from '@angular/core';
import { LIST_COURSE } from '../../../constant';

@Component({
  selector: 'app-list-course',
  templateUrl: './list-course.component.html',
  styleUrl: './list-course.component.css'
})
export class ListCourseComponent {
  list_course = LIST_COURSE
}
