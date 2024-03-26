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
  constructor(
    public dialogRef: MatDialogRef<DialogStudentComponent>,
    @Inject(MAT_DIALOG_DATA) public data: StudentModel,
  ) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
  private is_edit: boolean = false;

  student = {
    id: this.data.id,
    name: this.data.name,
    email: this.data.email,
  };

  ngOnInit(): void {
    if (this.data.id != null) {
      this.is_edit = true
    }
  }

  onSubmit(form: any) {
    if (this.is_edit) {
      studentService.update(this.student)
    } else {
      const data = {
        name: this.student.name,
        email: this.student.email
      }
      studentService.create(data)
    }
  }
}

