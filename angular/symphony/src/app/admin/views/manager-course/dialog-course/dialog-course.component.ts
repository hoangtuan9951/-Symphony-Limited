import { Component, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
} from '@angular/material/dialog';
import { CourseService } from '../../../services/course.service';
@Component({
  selector: 'app-dialog-course',
  templateUrl: './dialog-course.component.html',
  styleUrl: './dialog-course.component.css'
})
export class DialogCourseComponent {
    constructor(private courseService: CourseService,
        public dialogRef: MatDialogRef<DialogCourseComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    //@ts-ignore
    course = {
        
    };
    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    ngOnInit(): void {
        if (this.data.id) {
            this.is_edit = true;
        }
    }

    async onSubmit(form: any) {

        try {
           
            if (this.is_edit) {
                await this.courseService.update(this.course);
            } else {
                await this.courseService.create(this.course);
            }

            await this.data.callback();
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

