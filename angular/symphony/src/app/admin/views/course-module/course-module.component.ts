import { AfterViewInit, Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { CourseModules } from '../../models/CourseModule.model';
import { MatDialog } from '@angular/material/dialog';
import { DialogCourseModuleComponent } from './dialog-course-module/dialog-course-module.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
import courseModuleService from '../../services/courseModule.service';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-course-module',
  templateUrl: './course-module.component.html',
  styleUrl: './course-module.component.css',
})
export class CourseModuleComponent implements OnInit {
  dataSource = new MatTableDataSource<CourseModules>([]);
  displayedColumns: string[] = [
    'No',
    'Module Name',
    'Amount',
    'Description',
    'Course',
    'Action',
  ];

  dataSelect: CourseModules = {
    id: null,
    name: '',
    amount: 0,
    description: '',
    course: '',
  };

  constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) { }
  

  openDialog(): void {
      const dialogRef = this.dialog.open(DialogCourseModuleComponent, {
        data: {...this.dataSelect},
      });
  
      dialogRef.afterClosed().subscribe(result => {
        this.dataSelect = {
          id: null,
          name: '',
          amount: 0,
          description: '',
          course: '',
        };
      });
    }
  
  openEditDialog(data: CourseModules): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogCourseModuleComponent, {
      data: {...this.dataSelect},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        amount: 0,
        description: '',
        course: '',
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

  async handleDelete(id: number) {
    try {
      await courseModuleService.delete(id);
      this.openSnackBar('Delete about success!', '');
     
    } catch (error) {
      throw new Error((error as Error).message)
    }
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  handleGetListAdmin = async () => {
    //@ts-ignore
    this.dataSource = await courseModuleService.getList();
  }
  
  ngOnInit(): void {
    this.handleGetListAdmin()
  }
}
