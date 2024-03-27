import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { ContactUsModel } from '../../../models/ContactUs.model';
import contactService from '../../../services/contactUs.service';

@Component({
  selector: 'app-dialog-contatctus',
  templateUrl: './dialog-contatctus.component.html',
  styleUrl: './dialog-contatctus.component.css'
})

export class DialogContatctusComponent {
    public is_edit: boolean = false;

    constructor(
        public dialogRef: MatDialogRef<DialogContatctusComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    ngOnInit(): void {
        if (this.data.id != "") {
            this.is_edit = true
          }
    }

    contact = {
        email: this.data.email,
        address: this.data.address,
        hotline: this.data.hotline
    };

    async onSubmit(form: any) {
        if (this.is_edit) {
            contactService.update(this.contact)
          } else {
            contactService.create(this.contact)
          }
          await this.data.callback();
          this.dialogRef.close();
          }
}

