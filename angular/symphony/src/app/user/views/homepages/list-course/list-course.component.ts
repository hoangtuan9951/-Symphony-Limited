import { Component } from '@angular/core';
import { CourseService } from '../../../services/course.service';
import { CoursesModel } from '../../../models/course.model';

@Component({
  selector: 'app-list-course',
  templateUrl: './list-course.component.html',
  styleUrl: './list-course.component.css'
})
export class ListCourseComponent {
list_course: CoursesModel[] = [];
  constructor(private courseService: CourseService) { }
  ngOnInit(): void {
  this.courseService.getTopSixCousse().subscribe(response => {
     this.list_course = response;

  });
}
}

