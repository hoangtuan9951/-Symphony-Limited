import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import adminApi from '../../../service/admin';

@Component({
    selector: 'dialog-admin-component',
    templateUrl: './dialog.component.html',
    styleUrls: ['./dialog.component.scss'],
})
export class DialogManageAdmin {
    constructor(
        public dialogRef: MatDialogRef<DialogManageAdmin>,
        @Inject(MAT_DIALOG_DATA) public data: infoUser,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    ngOnInit(): void {
        console.log("data", this.data);
    }

    admin = {
        user_name: this.data.user_name,
        email: this.data.email,
        role: this.data.role,
        id: this.data.id,
        password: '',
    };

    async onSubmit(form: any) {
        await adminApi.updateAdmin({ id: this.admin.id, password: this.admin.password })
        this.onNoClick();
    }
}



