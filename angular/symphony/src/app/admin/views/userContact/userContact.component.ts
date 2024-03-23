// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'user-contact',
  templateUrl: './userContact.component.html',
  styleUrls: ['./userContact.component.scss'],
})

export class UserContactComponent implements AfterViewInit{
  displayedColumns: string[] = ['No', 'name', 'email', 'phone_number', 'message', 'status', 'action'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  dataSelect: PeriodicElement = {
    id: null,
    name: '',
    email: '',
    phone_number: '',
    message: '',
    status: '',
  }

  constructor(public dialog: MatDialog) {}

  handleDelete(id: number): void {
    console.log("delete user by id", id)
  }

  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnDestroy(): void {}
}

export interface PeriodicElement {
  id: number | null;
  name: string;
  email: string;
  phone_number: string;
  message: string;
  status: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {
    id: 1,
    name: 'Hydrogen',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 2,
    name: 'Helium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 3,
    name: 'Lithium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 4,
    name: 'Beryllium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 5,
    name: 'Boron',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 6,
    name: 'Carbon',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 7,
    name: 'Nitrogen',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 8,
    name: 'Oxygen',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 9,
    name: 'Fluorine',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 10,
    name: 'Neon',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 11,
    name: 'Sodium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 12,
    name: 'Magnesium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 13,
    name: 'Aluminum',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 14,
    name: 'Silicon',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 15,
    name: 'Phosphorus',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 16,
    name: 'Sulfur',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 17,
    name: 'Chlorine',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 18,
    name: 'Argon',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 19,
    name: 'Potassium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
  {
    id: 20,
    name: 'Calcium',
    email: 'test@gmail.com',
    phone_number: '0943983993',
    message: 'HIp hop nao cac bro',
    status: 'pending',
  },
];
