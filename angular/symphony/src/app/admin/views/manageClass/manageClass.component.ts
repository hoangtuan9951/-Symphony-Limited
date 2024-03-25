// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { DialogManageClass } from './dialog/dialog.component';
import classApi from '../../service/class';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'manage-class',
  templateUrl: './manageClass.component.html',
  styleUrls: ['./manageClass.component.scss'],
})

export class ManageClassComponent implements AfterViewInit{
  displayedColumns: string[] = ['No', 'name', 'start_time', 'amount', 'action'];
  dataSource = new MatTableDataSource<classesState>([]);
  name: string = '';

  dataSelect: classesState = {
    id: 0,
    name: '',
    amount: 0,
    start_time: '',
  }

  constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogManageClass, {
      data: {...this.dataSelect, callback: this.handleGetListClass, notify: () => {
        this.openSnackBar('create class success!', '');
      }},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: 0,
        name: '',
        amount: 0,
        start_time: '',
      };
    });
  }

  openEditDialog(data: classesState): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogManageClass, {
      data: {...this.dataSelect, title: 'Update class', callback: this.handleGetListClass, notify: () => {
        this.openSnackBar('Update class success!', '');
      }},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: 0,
        name: '',
        amount: 0,
        start_time: '',
      };
    });
  }

  async handleDelete(id: number) {
    const response = await classApi.deleteClass(id);
    this.handleGetListClass(this.name);
    this.openSnackBar('delete class success!', '');
  }

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {
      duration: 50000,
      horizontalPosition: 'end', // Vị trí ngang ('start' | 'center' | 'end')
      verticalPosition: 'top',
      panelClass: ['custom-snackbar']
    });
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnDestroy(): void {

  }

  handleGetListClass = async (name: string) => {
    //@ts-ignore
    this.dataSource = await classApi.getListClass(name);
  }

  ngOnInit(): void {
    this.handleGetListClass(this.name)
  }
}
