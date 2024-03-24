import { Component, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
} from '@angular/material/dialog';
import { CourseModules } from '../../../models/CourseModule.model';
import { FAQModel } from '../../../models/FAQ.model';

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
  styleUrl: './dialog-faq.component.css'
})
export class DialogFaqComponent {
  constructor(
    public dialogRef: MatDialogRef<DialogFaqComponent>,
    @Inject(MAT_DIALOG_DATA) public data: FAQModel,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit(): void {
    console.log("data", this.data);
  }

  faq = {
    question: this.data.question,
    answer: this.data.answer,
    active: this.data.active
  };

  onSubmit(form: any) {
    console.log('Admin Data:', form.value);
  }
}

