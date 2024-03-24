import { Component, OnInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { StudentModel } from '../../models/Student.model';
import { StudentService } from '../../services/student.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogStudentComponent } from './dialog-student/dialog-student.component';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent  implements OnInit {
  faqModel = new MatTableDataSource<StudentModel>();
  displayedColumns: string[] = ['No', 'Name', 'Email', 'Roll number','Password' , 'Created at', 'Update at' ,'Action'];
  dataSource = new MatTableDataSource<StudentModel>(ELEMENT_DATA);

  dataSelect: StudentModel = {
    id: null,
    username: '',
    roll_number: '',
    email: '',
    password: '',
    created_at: '',
    updated_at: '',
  }

  constructor(private studentervice: StudentService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getListFaq();
  }

  getListFaq(): void {
    this.studentervice.getAll().subscribe(faq => {
      this.faqModel = new MatTableDataSource(faq);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogStudentComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        username: '',
        roll_number: '',
        email: '',
        password: '',
        created_at: '',
        updated_at: '',
      };
    });
  }

  openEditDialog(data: StudentModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogStudentComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        username: '',
        roll_number: '',
        email: '',
        password: '',
        created_at: '',
        updated_at: '',
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
const ELEMENT_DATA: StudentModel[] = [
  {
    id: null,
    username: 'sdfdsf',
    roll_number: 'dsfdsfdsf',
    email: 'sdfdsf',
    password: 'sdfsdf',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
];
