    import { Component, Inject } from '@angular/core';
    import {
        MAT_DIALOG_DATA,
        MatDialogRef,
    } from '@angular/material/dialog';
import classApi from '../../../service/class';

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
        is_edit: boolean = false;

        constructor(
            public dialogRef: MatDialogRef<DialogManageClass>,
            @Inject(MAT_DIALOG_DATA) public data: any, 
        ) {
            this.title = data.title ? data.title : 'Create class'
         }

        onNoClick(): void {
            this.dialogRef.close();
        }

        ngOnInit(): void {
            console.log("data", this.data);
            if(this.data.id) {
                this.is_edit = true;
                
            } 
        }

        admin = {
            name: this.data.name,
            amount: this.data.amount,
            start_time: this.data.start_time,
            id: this.data.id,
        };

        async onSubmit(form: any) {
            const date = new Date(form.value.start_time)
            const body = {name: this.admin.name, start_time: date, amount: this.admin.amount};

            if(this.is_edit) {
                //@ts-ignore
                body['id'] = this.admin.id;
            }
          
            if(this.is_edit) {
                await classApi.createClass({...form.value, start_time: date})
            } else {
                await classApi.createClass({...form.value, start_time: date})
            }

            this.data.notify();
            await this.data.callback();
            this.onNoClick()
        }
    }

