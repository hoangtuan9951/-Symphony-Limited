import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { StudentModel } from '../../../models/Student.model';
import studentService from '../../../services/student.service';

@Component({
  selector: 'app-dialog-student',
  templateUrl: './dialog-student.component.html',
  styleUrl: './dialog-student.component.css'
})
export class DialogStudentComponent {
  public is_edit: boolean = false;

  constructor(
    public dialogRef: MatDialogRef<DialogStudentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: any,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

  student = {
    id: this.data.id,
    name: this.data.name,
    email: this.data.email,
    rollNumber: this.data.rollNumber
  };

  ngOnInit(): void {
    if (this.data.rollNumber != "") {
      this.is_edit = true
    }
  }

  async onSubmit(form: any) {
    if (this.is_edit) {
      studentService.update(this.student)
    } else {
      const data = {
        name: this.student.name,
        email: this.student.email,
        rollNumber: this.student.rollNumber
      }
      studentService.create(data)
    }
    this.dialogRef.close();

  }
}

