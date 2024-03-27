import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { FAQModel } from '../../models/FAQ.model';
import { MatDialog } from '@angular/material/dialog';
import faqService from '../../services/faq.service';
import { DialogFaqComponent } from './dialog-faq/dialog-faq.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
@Component({
  selector: 'app-manager-faq',
  templateUrl: './manager-faq.component.html',
  styleUrl: './manager-faq.component.css'
})
export class ManagerFaqComponent  implements OnInit {
  faqModel = new MatTableDataSource<FAQModel>();
  displayedColumns: string[] = ['No', 'Question', 'Answer', 'Active',  'Created at', 'Update at' ,'Action'];
  dataSource = new MatTableDataSource<FAQModel>(ELEMENT_DATA);

  dataSelect: FAQModel = {
    id: null,
    question: '',
    answer: '',
    active: true,
  }

  constructor(public dialog: MatDialog, private _snackBar: MatSnackBar) { }

  ngOnInit(): void {
    this.getListFaq();
  }

  getListFaq(): void {
    faqService.getList().then(faq => {
      this.faqModel = new MatTableDataSource(faq);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogFaqComponent, {
      data:  {...this.dataSelect, callback: this.getListFaq()}
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        question: '',
        answer: '',
        active: true
      };
    });
  }

  openEditDialog(data: FAQModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogFaqComponent, {
      data:  {...this.dataSelect, callback: this.getListFaq()}
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        question: '',
        answer: '',
        active: true
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
    faqService.delete(id).then(() =>{
      this.getListFaq();
      this.openSnackBar('Delete about success!', '');

    })
  }
  //@ts-ignore
  @ViewChild(MatPaginator) paginator: MatPaginator;

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  ngOnDestroy(): void { }
}
const ELEMENT_DATA: FAQModel[] = [
  {
    id: 1,
    question: 'aaaaaaaaaaaaaaaaa',
    active: true,
    answer: 'bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb'
  },
];
