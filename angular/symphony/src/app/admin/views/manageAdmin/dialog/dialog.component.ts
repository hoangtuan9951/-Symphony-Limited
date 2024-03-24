    import { Component, Inject } from '@angular/core';
    import {
        MAT_DIALOG_DATA,
        MatDialogRef,
    } from '@angular/material/dialog';

    export interface DialogData {
        animal: string;
        name: string;
    }

    export interface PeriodicElement {
        id: number | null;
        username: string;
        email: string;
        role: string;
        created_at: string | null;
        updated_at: string | null;
      }

    /**
     * @title Dialog Overview
     */
    @Component({
        selector: 'dialog-admin-component',
        templateUrl: './dialog.component.html',
        styleUrls: ['./dialog.component.scss'],
    })
    export class DialogManageAdmin {
        constructor(
            public dialogRef: MatDialogRef<DialogManageAdmin>,
            @Inject(MAT_DIALOG_DATA) public data: PeriodicElement,
        ) { }

        onNoClick(): void {
            this.dialogRef.close();
        }

        ngOnInit(): void {
            console.log("data", this.data);
        }

        admin = {
            username: this.data.username,
            email: this.data.email,
            role: this.data.role
        };

        onSubmit(form: any) {
            console.log('Admin Data:', form.value);
        }
    }

