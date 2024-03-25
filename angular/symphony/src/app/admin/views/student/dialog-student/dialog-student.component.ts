import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { StudentModel } from '../../../models/Student.model';

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

  ngOnInit(): void {
    console.log("data", this.data);
  }

  student = {
    username: this.data.username,
    email: this.data.email,
    password: this.data.password,
    roll_number: this.data.roll_number,
  };

  onSubmit(form: any) {
    console.log('Admin Data:', form.value);
  }
}

