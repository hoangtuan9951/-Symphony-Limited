import { Component } from '@angular/core';
import { CourseService } from '../../../services/course.service';
import { CoursesModel } from '../../../models/course.model';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-list-course',
  templateUrl: './list-course.component.html',
  styleUrl: './list-course.component.css',
})
export class ListCourseComponent {
  list_course: CoursesModel[] = [];
  constructor(
    private courseService: CourseService,
    private datePipe: DatePipe
  ) {}
  ngOnInit(): void {
    this.courseService.getTopSixCousse().subscribe((response) => {
      response.forEach((obj) => {
        const startDateObj = new Date(obj.startedDate);
        const endDateObj = new Date(obj.endedDate);

        const differenceInTime = endDateObj.getTime() - startDateObj.getTime();
        const differenceInDays = differenceInTime / (1000 * 3600 * 24);

        obj.numberOfDay = Math.round(differenceInDays);

        obj.startedDate = this.formatDate(obj.startedDate);

      });
      this.list_course = response;
    });
  }
  formatDate(startDate: string | null): string {
    if (startDate === null) {
      return '';
    }
    const inputDate = new Date(startDate);
    return this.datePipe.transform(inputDate, 'dd/MM/yyyy') || '';
  }
}
