import { AfterViewInit, Component, SimpleChanges, ViewChild } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { getBase64 } from '../../constant';
import { MatTableDataSource } from '@angular/material/table';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DialogManageAboutUs } from './dialog/dialog.component';
import { MatPaginator } from '@angular/material/paginator';
import adminApi from '../../service/admin';
import aboutUsApi from '../../service/aboutUs';

@Component({
    selector: 'about-us',
    templateUrl: './aboutUs.component.html',
    styleUrls: ['./aboutUs.component.scss'],
})


export class AboutUsComponent implements AfterViewInit {
    displayedColumns: string[] = ['No', 'backgroundImage', 'description', 'action'];
    dataSource = new MatTableDataSource<infoUser>([]);
    user_name = '';
  
    dataSelect: aboutUsState = {
      id: 0,
      description: '',
      backgroundImage: '',
      created_at: '',
      updated_at: '',
    }
  
    constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) { }
  
    handleSearchByName = async () => {
      //@ts-ignore
      this.dataSource = await aboutUsApi.getListAboutUs(this.user_name);
    }

    openDialog(): void {
        const dialogRef = this.dialog.open(DialogManageAboutUs, {
          data: {...this.dataSelect, callback: this.handleSearchByName},
        });
    
        dialogRef.afterClosed().subscribe(result => {
          this.dataSelect = {
            id: 0,
            description: '',
            backgroundImage: '',
            created_at: '',
            updated_at: ''
          };
        });
      }
    
    openEditDialog(data: aboutUsState): void {
      this.dataSelect = data;
  
      const dialogRef = this.dialog.open(DialogManageAboutUs, {
        data: {...this.dataSelect, callback: this.handleSearchByName},
      });
  
      dialogRef.afterClosed().subscribe(result => {
        this.dataSelect = {
          id: 0,
          description: '',
          backgroundImage: '',
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
  
    async handleDelete(id: number) {
      try {
        await aboutUsApi.deleteAboutUs(id);
        await this.handleSearchByName();
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
  
    handleGetListAdmin = async (user_name: string) => {
      //@ts-ignore
      this.dataSource = await aboutUsApi.getListAboutUs(user_name);
      console.log(user_name);

    }
    
    ngOnInit(): void {
      this.handleGetListAdmin(this.user_name)
    }
  }
