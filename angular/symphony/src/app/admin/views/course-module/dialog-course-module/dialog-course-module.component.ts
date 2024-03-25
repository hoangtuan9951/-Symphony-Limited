import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import { CourseModules } from '../../../models/CourseModule.model';

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
        @Inject(MAT_DIALOG_DATA) public data: CourseModules,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    ngOnInit(): void {
        console.log("data", this.data);
    }

    module = {
        module_name: this.data.module_name,
        amount: this.data.amount,
        active: this.data.active
    };

    onSubmit(form: any) {
        console.log('Admin Data:', form.value);
    }
}

