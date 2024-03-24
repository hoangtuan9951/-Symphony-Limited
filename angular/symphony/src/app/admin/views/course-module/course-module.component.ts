import { AfterViewInit, Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { CourseModules } from '../../models/CourseModule.model';
import { CourseModulesService } from '../../services/courseModule.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogCourseModuleComponent } from './dialog-course-module/dialog-course-module.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';

@Component({
  selector: 'app-course-module',
  templateUrl: './course-module.component.html',
  styleUrl: './course-module.component.css'
})

export class CourseModuleComponent implements OnInit {
  courseModules = new MatTableDataSource<CourseModules>();
  displayedColumns: string[] = ['No', 'Module Name', 'Amount', 'Active', 'Course' , 'Created at', 'Update at' ,'Action'];
  dataSource = new MatTableDataSource<CourseModules>(ELEMENT_DATA);

  dataSelect: CourseModules = {
    id: null,
    module_name: '',
    amount: 0,
    active: true,
    course_id: '',
    created_at: null,
    updated_at: null,
  }

  constructor(private courseModulesService: CourseModulesService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getCourseModules();
  }

  getCourseModules(): void {
    this.courseModulesService.getAll().subscribe(courseModules => {
      this.courseModules = new MatTableDataSource(courseModules);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogCourseModuleComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        module_name: '',
        amount: 0,
        active: true,
        course_id: '',
        created_at: null,
        updated_at: null,
      };
    });
  }

  openEditDialog(data: CourseModules): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogCourseModuleComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        module_name: '',
        amount: 0,
        active: true,
        course_id : '',
        created_at: null,
        updated_at: null,
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
const ELEMENT_DATA: CourseModules[] = [
  {
    id: 1,
    module_name: 'Hydrogen',
    active: true,
    amount: 10000,
    course_id: '12345',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
];
