import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ContactUsModel } from '../../../models/ContactUs.model';

@Component({
  selector: 'app-dialog-contatctus',
  templateUrl: './dialog-contatctus.component.html',
  styleUrl: './dialog-contatctus.component.css'
})

export class DialogContatctusComponent {
    constructor(
        public dialogRef: MatDialogRef<DialogContatctusComponent>,
        @Inject(MAT_DIALOG_DATA) public data: ContactUsModel,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    ngOnInit(): void {
        console.log("data", this.data);
    }

    contact = {
        email: this.data.email,
        address: this.data.address,
        hotline: this.data.hotline
    };

    onSubmit(form: any) {
        console.log('Admin Data:', form.value);
    }
}

