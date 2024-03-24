import { Component, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { FAQModel } from '../../models/FAQ.model';
import { MatDialog } from '@angular/material/dialog';
import { FAQService } from '../../services/faq.service';
import { DialogFaqComponent } from './dialog-faq/dialog-faq.component';
import { MatPaginator } from '@angular/material/paginator';
import { ViewChild } from '@angular/core';
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
    created_at: null,
    updated_at: null,
  }

  constructor(private faqService: FAQService, public dialog: MatDialog) { }

  ngOnInit(): void {
    this.getListFaq();
  }

  getListFaq(): void {
    this.faqService.getAll().subscribe(faq => {
      this.faqModel = new MatTableDataSource(faq);
    });
  }
  openDialog(): void {
    const dialogRef = this.dialog.open(DialogFaqComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        question: '',
        answer: '',
        active: true,
        created_at: null,
        updated_at: null,
      };
    });
  }

  openEditDialog(data: FAQModel): void {
    this.dataSelect = data;

    const dialogRef = this.dialog.open(DialogFaqComponent, {
      data: this.dataSelect,
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataSelect = {
        id: null,
        question: '',
        answer: '',
        active: true,
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
const ELEMENT_DATA: FAQModel[] = [
  {
    id: 1,
    question: 'aaaaaaaaaaaaaaaaa',
    active: true,
    answer: 'bbbbbbbbbbbbbbbbbbbbbbbbbbbbbb',
    created_at: '2023-03-10',
    updated_at: '2024-03-16',
  },
];
