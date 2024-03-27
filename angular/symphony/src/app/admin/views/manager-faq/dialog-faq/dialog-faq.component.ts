import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { CourseModules } from '../../../models/CourseModule.model';
import { FAQModel } from '../../../models/FAQ.model';
import faqService from '../../../services/faq.service';

export interface DialogData {
  animal: string;
  name: string;
}

/**
 * @title Dialog Overview
 */
@Component({
  selector: 'app-dialog-faq',
  templateUrl: './dialog-faq.component.html',
  styleUrl: './dialog-faq.component.css',
})
export class DialogFaqComponent {
  public is_edit: boolean = false;

  faq: FAQModel = {
    question: this.data.question,
    answer: this.data.answer,
    active: this.data.active,
    id: this.data.id,
  };

  constructor(
    public dialogRef: MatDialogRef<DialogFaqComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any
  ) {}

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit(): void {
    if (this.data.id != null) {
      this.is_edit = true;
    }
  }

  async onSubmit(form: any) {
    if (this.is_edit) {
      faqService.update(this.faq);
    } else {
      faqService.create(this.faq);
    }
    this.dialogRef.close();
  }
}
