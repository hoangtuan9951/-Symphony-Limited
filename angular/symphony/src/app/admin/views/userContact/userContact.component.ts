// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import contactApi from '../../service/contact';
import { DialogManageContact } from './dialog/dialog.component';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'user-contact',
  templateUrl: './userContact.component.html',
  styleUrls: ['./userContact.component.scss'],
})

export class UserContactComponent implements AfterViewInit{
  displayedColumns: string[] = ['No', 'name', 'email', 'phone_number', 'address', 'status', 'action'];
  dataSource = new MatTableDataSource<contactState>([]);
  user_name: string = '';

  dataSelect: contactState = {
    id: 0,
    name: '',
    message: '',
    status: 'unactive',
    address: '',
    email: '',
    phone_number: '',
    created_at: '',
    updated_at: ''
  }

  constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) {}

  openEditDialog(data: contactState): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogManageContact, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: 0,
        name: '',
        message: '',
        status: 'unactive',
        phone_number: '',
        email: '',
        address: '',
        created_at: '',
        updated_at: '',
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

  handleSearchByName = async () => {
    //@ts-ignore
    this.dataSource = await contactApi.getListContact(this.user_name);
  }
  

  async handleDelete(id: number) {
   try {
    const result = await contactApi.deleteContact(id);
    this.openSnackBar('Delete contact success!', '');
   } catch(error) {
    throw new Error((error as Error).message)
   }
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  handleGetListContact = async (user_name: string) => {
    //@ts-ignore
    this.dataSource = await contactApi.getListContact(user_name);
  }

  ngOnInit(): void {
    this.handleGetListContact(this.user_name)
  }
}
