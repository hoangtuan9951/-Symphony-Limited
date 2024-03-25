import { Component, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
} from '@angular/material/dialog';
import { CourseModules } from '../../../models/CourseModule.model';
import { FAQCreateModel, FAQModel } from '../../../models/FAQ.model';
import { FAQService } from '../../../services/faq.service';

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
  faq: FAQCreateModel = {
    question: this.data.question,
    answer: this.data.answer,
    active: this.data.active
  };
  
  constructor(
    private apiService: FAQService,
    public dialogRef: MatDialogRef<DialogFaqComponent>,
    @Inject(MAT_DIALOG_DATA) public data: FAQModel,
    
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  ngOnInit(): void {
    console.log("data", this.data);
  }


  onSubmit(form: any) {
    this.apiService.create(this.faq).subscribe(response => {
    }, error => {
      console.error('Error:', error);
    });
  }
}

