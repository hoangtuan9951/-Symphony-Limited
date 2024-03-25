import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import contactApi from '../../../service/contact';

@Component({
    selector: 'dialog-admin-component',
    templateUrl: './dialog.component.html',
    styleUrls: ['./dialog.component.scss'],
})
export class DialogManageContact {
    constructor(
        public dialogRef: MatDialogRef<DialogManageContact>,
        @Inject(MAT_DIALOG_DATA) public data: contactState,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    ngOnInit(): void {
        console.log("data", this.data);
    }

    admin = {
        phone_number: this.data.phone_number,
        email: this.data.email,
        address: this.data.address,
        name: this.data.name,
        status: this.data.status,
        message: this.data.message,
        id: this.data.id,
    };

    async onSubmit(form: any) {
        //@ts-ignore
        await contactApi.updateContact({...this.admin})
        this.onNoClick();
    }
}

