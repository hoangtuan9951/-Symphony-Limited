// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { DialogManageClass } from './dialog/dialog.component';

@Component({
  selector: 'manage-class',
  templateUrl: './manageClass.component.html',
  styleUrls: ['./manageClass.component.scss'],
})

export class ManageClassComponent implements AfterViewInit{
  displayedColumns: string[] = ['No', 'name', 'start_time', 'amount', 'action'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  dataSelect: PeriodicElement = {
    id: null,
    name: '',
    amount: '',
    start_time: '',
  }

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogManageClass, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        amount: '',
        start_time: '',
      };
    });
  }

  openEditDialog(data: PeriodicElement): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogManageClass, {
      data: {...this.dataSelect, title: 'Update class'},
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        name: '',
        amount: '',
        start_time: '',
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

  ngOnDestroy(): void {}
}

export interface PeriodicElement {
  id: number | null;
  name: string;
  start_time: string;
  amount: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {
    id: 1,
    name: 'Hydrogen',
    start_time: '26-03-2024',
    amount: '30',
  },
  {
    id: 2,
    name: 'Helium',
    start_time: '26-03-2024',
    amount: '30',
  },
  {
    id: 3,
    name: 'Lithium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 4,
    name: 'Beryllium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 5,
    name: 'Boron',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 6,
    name: 'Carbon',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 7,
    name: 'Nitrogen',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 8,
    name: 'Oxygen',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 9,
    name: 'Fluorine',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 10,
    name: 'Neon',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 11,
    name: 'Sodium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 12,
    name: 'Magnesium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 13,
    name: 'Aluminum',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 14,
    name: 'Silicon',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 15,
    name: 'Phosphorus',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 16,
    name: 'Sulfur',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 17,
    name: 'Chlorine',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 18,
    name: 'Argon',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 19,
    name: 'Potassium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
  {
    id: 20,
    name: 'Calcium',
    start_time: 'admin@gmail.com',
    amount: '20',
  },
];
