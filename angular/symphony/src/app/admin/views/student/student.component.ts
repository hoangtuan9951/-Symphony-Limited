import { Component, OnInit } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { StudentModel } from '../../models/Student.model';
import studentService from '../../services/student.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogStudentComponent } from './dialog-student/dialog-student.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-student',
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})
export class StudentComponent  implements OnInit {
  dataSource = new MatTableDataSource<StudentModel>([]);
  displayedColumns: string[] = ['No', 'Name', 'Email', 'Roll number' ,'Action'];

  dataSelect: StudentModel = {
    id: null,
    name: '',
    rollNumber: '',
    email: '',
  }

  constructor( public dialog: MatDialog,  private _snackBar: MatSnackBar) { }

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogStudentComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        rollNumber: '',
        email: '',
      };
    });
  }

  openEditDialog(data: StudentModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogStudentComponent, {
      data: {...this.dataSelect, callback: this.handleGetListAdmin}
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        rollNumber: '',
        email: ''
      };
    });
  }
  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 50000,
      horizontalPosition: 'end', // Vị trí ngang ('start' | 'center' | 'end')
      verticalPosition: 'top',
      panelClass: ['custom-snackbar']
    });
  }
  handleDelete(rollNumber: number): void {
    studentService.delete(rollNumber);
    this.openSnackBar('Delete about success!', '');
    this.handleGetListAdmin
    }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  handleGetListAdmin = async () => {
    //@ts-ignore
    this.dataSource = await studentService.getList();
  }
  
  ngOnInit(): void {
    this.handleGetListAdmin()
  }
}
