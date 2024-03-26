import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import courseService from '../../../services/course.service';
export interface DialogData {
    animal: string;
    name: string;
}

/**
 * @title Dialog Overview
 */
@Component({
    selector: 'dialog-admin-component',
    templateUrl: './dialog-course-module.component.html',
    styleUrls: ['./dialog-course-module.component.scss'],
})
export class DialogCourseModuleComponent {
    constructor(
        public dialogRef: MatDialogRef<DialogCourseModuleComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    module = {
        id: 0,
        name: '',
        amount: 0,
        description: '',
        course:'',
    };
    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    ngOnInit(): void {
        if (this.data.id) {
            this.is_edit = true;
            this.module.name = this.data.name;
            this.module.amount = this.data.amount;
            this.module.description = this.data.description;
            this.module.course = this.data.course;
            this.module.id = this.data.id

        }
    }

    async onSubmit(form: any) {

        try {

            if (this.is_edit) {
                const body = {
                    id:this.module.id,
                    name: this.module.name,
                    amount: this.module.amount,
                    description: this.module.description,
                    course: this.module.course
                };

                await courseService.update(body);
            } else {
                const body = {
                    name: this.module.name,
                    amount: this.module.amount,
                    description: this.module.description,
                    course: this.module.course
                };
                await courseService.create(body);
            }

            await this.data.callback();
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

