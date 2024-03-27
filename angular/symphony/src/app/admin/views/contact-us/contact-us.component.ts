import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ContactUsModel } from '../../models/ContactUs.model';
import contactService from '../../services/contactUs.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogContatctusComponent } from './dialog-contatctus/dialog-contatctus.component';
import { ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrl: './contact-us.component.css'
})
export class ContactUsComponent implements OnInit {
  courseModules = new MatTableDataSource<ContactUsModel>();
  displayedColumns: string[] = ['No', 'Email', 'Address', 'Hotline', 'Action'];

  dataSelect: ContactUsModel = {
    id: null,
    email: '',
    address: '',
    hotline: ''
  }

  constructor(public dialog: MatDialog ,  private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.getContact();
  }

  getContact(): void {
    contactService.getList().then(contact => {
      this.courseModules = new MatTableDataSource(contact);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogContatctusComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.getContact();

      this.dataSelect = {
        id: null,
        email: '',
        address: '',
        hotline: ''
      };
    });
  }

  openEditDialog(data: ContactUsModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogContatctusComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.getContact();
      this.dataSelect = {
        id: null,
        email: '',
        address: '',
        hotline: ''
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
  handleDelete(id: number): void {
    contactService.delete(id).then(() => {
      this.getContact();
      this.openSnackBar('Delete about success!', '');

    })
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.courseModules.paginator = this.paginator;
  }

  ngOnDestroy(): void { }
}
