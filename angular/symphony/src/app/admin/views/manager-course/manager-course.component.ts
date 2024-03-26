import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { CourseModel } from '../../models/Course.model';
import { MatDialog } from '@angular/material/dialog';
import { DialogCourseComponent } from './dialog-course/dialog-course.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
import courseService from '../../services/course.service';
@Component({
  selector: 'app-manager-course',
  templateUrl: './manager-course.component.html',
  styleUrl: './manager-course.component.css'
})
export class ManagerCourseComponent  implements OnInit {
  dataSource = new MatTableDataSource<CourseModel>([]);
  displayedColumns: string[] = ['No', 'Name', 'Code', 'Amount', 'Discount' ,'BackgoundImage' ,'Start date', 'End date', 'Active', 'Action'];

  dataSelect: CourseModel = {
    id: null,
    name: '',
    code: '',
    amount: 0,
    discount: '',
    startedDate: '',
    endedDate: '',
    active: false,
    thumbnail: ''
  }

  constructor( public dialog: MatDialog) { }

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
        startedDate: '',
        endedDate: '',
        active: false  ,
        thumbnail: ''     
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
        startedDate: '',
        endedDate: '',
        active: false,
        thumbnail: ''
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

  handleGetListAdmin = async () => {
    //@ts-ignore
    this.dataSource = await courseService.getList();
  }
  
  ngOnInit(): void {
    this.handleGetListAdmin()
  }
}