import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { ContactUsModel } from '../../models/ContactUs.model';
import { ContactUsService } from '../../services/contactUs.service';
import { MatDialog } from '@angular/material/dialog';
import { DialogContatctusComponent } from './dialog-contatctus/dialog-contatctus.component';
import { ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';

@Component({
  selector: 'app-contact-us',
  templateUrl: './contact-us.component.html',
  styleUrl: './contact-us.component.css'
})
export class ContactUsComponent implements OnInit {
  courseModules = new MatTableDataSource<ContactUsModel>();
  displayedColumns: string[] = ['No', 'Email', 'Address', 'Hotline', 'Created at', 'Update at', 'Action'];
  dataSource = new MatTableDataSource<ContactUsModel>(ELEMENT_DATA);

  dataSelect: ContactUsModel = {
    id: null,
    email: '',
    address: '',
    hotline: '',
    created_at: null,
    updated_at: null,
  }

  constructor(private contactUsService: ContactUsService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getContact();
  }

  getContact(): void {
    this.contactUsService.getAll().subscribe(contact => {
      this.courseModules = new MatTableDataSource(contact);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogContatctusComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        email: '',
        address: '',
        hotline: '',
        created_at: null,
        updated_at: null,
      };
    });
  }

  openEditDialog(data: ContactUsModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogContatctusComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        email: '',
        address: '',
        hotline: '',
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
const ELEMENT_DATA: ContactUsModel[] = [
  {
    id: null,
    email: 'dsadsad',
    address: 'ádasd',
    hotline: 'ádasdasdasdasd',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
];
