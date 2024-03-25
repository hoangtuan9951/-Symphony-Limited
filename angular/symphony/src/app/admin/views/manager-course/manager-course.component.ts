import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { CourseModel } from '../../models/Course.model';
import { CourseService } from '../../services/course.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogCourseComponent } from './dialog-course/dialog-course.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
@Component({
  selector: 'app-manager-course',
  templateUrl: './manager-course.component.html',
  styleUrl: './manager-course.component.css'
})
export class ManagerCourseComponent  implements OnInit {
  courseModules = new MatTableDataSource<CourseModel>();
  displayedColumns: string[] = ['No', 'Name', 'Code', 'Amount', 'Discount' , 'Description' ,'BackgoundImage' , 'Active', 'Action'];
  dataSource = new MatTableDataSource<CourseModel>(ELEMENT_DATA);

  dataSelect: CourseModel = {
    id: null,
    name: '',
    code: '',
    amount: 0,
    discount: '',
    description: '',
    courseDetail: '',
    backGroundImage: '',
    startedDate: '',
    endedDate: '',
    active: false
  }

  constructor(private service: CourseService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getCourseModules();
  }

  getCourseModules(): void {
    this.service.getAll().subscribe(courseModules => {
      this.courseModules = new MatTableDataSource(courseModules);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogCourseComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        code: '',
        amount: 0,
        discount: '',
        description: '',
        courseDetail: '',
        backGroundImage: '',
        startedDate: '',
        endedDate: '',
        active: false       
      };
    });
  }

  openEditDialog(data: CourseModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogCourseComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        code: '',
        amount: 0,
        discount: '',
        description: '',
        courseDetail: '',
        backGroundImage: '',
        startedDate: '',
        endedDate: '',
        active: false
      };
    });
  }

  handleDelete(id: number): void {
    console.log("delete user by id", id)
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnDestroy(): void { }
}
const ELEMENT_DATA: CourseModel[] = [
  {
    id: 1,
    name: '',
    code: '',
    amount: 0,
    discount: '',
    description: '',
    courseDetail: '',
    backGroundImage: '',
    startedDate: '',
    endedDate: '',
    active: false
  },
];
