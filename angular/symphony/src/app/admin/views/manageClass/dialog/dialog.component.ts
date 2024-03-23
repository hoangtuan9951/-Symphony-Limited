    import { Component, Inject } from '@angular/core';
    import {
        MAT_DIALOG_DATA,
        MatDialogRef,
    } from '@angular/material/dialog';

    export interface PeriodicElement {
        id: number | null;
        name: string;
        amount: string;
        start_time: string;
        title: string;
      }

    /**
     * @title Dialog Overview
     */
    @Component({
        selector: 'dialog-class-component',
        templateUrl: './dialog.component.html',
        styleUrls: ['./dialog.component.scss'],
    })
    export class DialogManageClass {
        title: string;

        constructor(
            public dialogRef: MatDialogRef<DialogManageClass>,
            @Inject(MAT_DIALOG_DATA) public data: PeriodicElement, 
        ) {
            this.title = data.title ? data.title : 'Create class'
         }

        onNoClick(): void {
            this.dialogRef.close();
        }

        ngOnInit(): void {
            console.log("data", this.data);
        }

        admin = {
            name: this.data.name,
            amount: this.data.amount,
            start_time: this.data.start_time
        };

        onSubmit(form: any) {
            console.log('Admin Data:', form.value);
        }
    }

