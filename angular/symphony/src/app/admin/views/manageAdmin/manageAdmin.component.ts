// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { DialogManageAdmin } from './dialog/dialog.component';
import adminApi from '../../service/admin';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'manage-admin',
  templateUrl: './manageAdmin.component.html',
  styleUrls: ['./manageAdmin.component.scss'],
})

export class ManageAdminComponent implements AfterViewInit {
  displayedColumns: string[] = ['No', 'user_name', 'email', 'role', 'created_at', 'action'];
  dataSource = new MatTableDataSource<infoUser>([]);
  user_name = '';

  dataSelect: infoUser = {
    id: 0,
    user_name: '',
    email: '',
    role: '',
    created_at: '',
    updated_at: '',
    success: false,
  }

  constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) { }

  handleSearchByName = async () => {
    //@ts-ignore
    this.dataSource = await adminApi.getListAdmin(this.user_name);
  }
  
  openEditDialog(data: infoUser): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogManageAdmin, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: 0,
        user_name: '',
        email: '',
        role: '',
        created_at: '',
        updated_at: '',
        success: false,
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
      const result = await adminApi.deleteAdmin(id);
      this.openSnackBar('Delete user success!', '');

    } catch (error) {
      throw new Error((error as Error).message)
    }
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  handleGetListAdmin = async (user_name: string) => {
    //@ts-ignore
    this.dataSource = await adminApi.getListAdmin(user_name);
  }

  ngOnInit(): void {
    this.handleGetListAdmin(this.user_name)
  }
}
