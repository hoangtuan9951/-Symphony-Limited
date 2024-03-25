import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import { CourseModules } from '../../../models/CourseModule.model';
import { CourseModulesService } from '../../../services/courseModule.service';

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
        private service: CourseModulesService,
        public dialogRef: MatDialogRef<DialogCourseModuleComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    module = {
        id: 0,
        module_name: '',
        amount: '',
        active: true,
    };
    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    ngOnInit(): void {
        if (this.data.id) {
            this.is_edit = true;
            this.module.module_name = this.data.module_name;
            this.module.amount = this.data.amount;
            this.module.active = this.data.active;
            this.module.id = this.data.id

        }
    }

    async onSubmit(form: any) {

        try {

            if (this.is_edit) {
                const body = {
                    id:this.module.id,
                    module_name: this.module.module_name,
                    amount: this.module.amount,
                    active: this.module.active
                };

                await this.service.update(body);
            } else {
                const body = {
                    module_name: this.module.module_name,
                    amount: this.module.amount,
                    active: this.module.active
                };
                await this.service.create(body);
            }

            await this.data.callback();
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

