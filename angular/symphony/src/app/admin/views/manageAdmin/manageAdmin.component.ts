// home.component.ts

import { Component, ViewChild, AfterViewInit } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { DialogManageAdmin } from './dialog/dialog.component';

@Component({
  selector: 'manage-admin',
  templateUrl: './manageAdmin.component.html',
  styleUrls: ['./manageAdmin.component.scss'],
})

export class ManageAdminComponent implements AfterViewInit{
  displayedColumns: string[] = ['No', 'username', 'email', 'role', 'created_at', 'action'];
  dataSource = new MatTableDataSource<PeriodicElement>(ELEMENT_DATA);

  dataSelect: PeriodicElement = {
    id: null,
    username: '',
    email: '',
    role: '',
    created_at: null,
    updated_at: null,
  }

  constructor(public dialog: MatDialog) {}

  openDialog(): void {
    const dialogRef = this.dialog.open(DialogManageAdmin, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        username: '',
        email: '',
        role: '',
        created_at: null,
        updated_at: null,
      };
    });
  }

  openEditDialog(data: PeriodicElement): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogManageAdmin, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        username: '',
        email: '',
        role: '',
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

  ngOnDestroy(): void {}
}

export interface PeriodicElement {
  id: number | null;
  username: string;
  email: string;
  role: string;
  created_at: string | null;
  updated_at: string | null;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {
    id: 1,
    username: 'Hydrogen',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 2,
    username: 'Helium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 3,
    username: 'Lithium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 4,
    username: 'Beryllium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 5,
    username: 'Boron',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 6,
    username: 'Carbon',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 7,
    username: 'Nitrogen',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 8,
    username: 'Oxygen',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 9,
    username: 'Fluorine',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 10,
    username: 'Neon',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 11,
    username: 'Sodium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 12,
    username: 'Magnesium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 13,
    username: 'Aluminum',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 14,
    username: 'Silicon',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 15,
    username: 'Phosphorus',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 16,
    username: 'Sulfur',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 17,
    username: 'Chlorine',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 18,
    username: 'Argon',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 19,
    username: 'Potassium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
  {
    id: 20,
    username: 'Calcium',
    email: 'admin@gmail.com',
    role: 'admin',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
];
