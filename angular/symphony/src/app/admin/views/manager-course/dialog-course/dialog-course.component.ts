import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import { getBase64 } from '../../../constant';
import courseService from '../../../services/course.service';
import { CourseCreateModel } from '../../../models/Course.model';
@Component({
    selector: 'app-dialog-course',
    templateUrl: './dialog-course.component.html',
    styleUrl: './dialog-course.component.css'
})
export class DialogCourseComponent {
    constructor(
        public dialogRef: MatDialogRef<DialogCourseComponent>,
        @Inject(MAT_DIALOG_DATA) public data: any
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }
    course : CourseCreateModel = {
        name: '',
        code: '',
        amount: 0,
        discount: 0,
        description: '',
        backGroundImage: null,
        startedDate: '',
        endedDate: '',
        active: false,
        gradePass: 0,
        thumbnail: null,
        fee: 0,
        feeChargeDate: ''
    }

    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    async onFileSelected(event: any) {

        const file: File = event.target.files[0];
        if (file) {
            this._imageSelected = file;
            this.data.backGroundImage = this._imageSelected;
            this.data.thumbnail = this._imageSelected


        }
    }

    async ngOnInit(): Promise<void> {
        if (this.data != null) {
            this.is_edit = true;
            this.course = await courseService.getDetail(this.data);
        }
    }


    async onSubmit(form: any) {

        try {
            const body = {
                name: this.course.name,
                code: this.course.code,
                amount: this.course.amount,
                discount: this.course.discount,
                description: this.course.description,
                thumbnail: this.course.thumbnail,
                backGroundImage: this.course.backGroundImage,
                startedDate: this.course.startedDate,
                endedDate: this.course.endedDate,
                active: this.course.active,
                fee: this.course.fee,
                gradePass: this.course.gradePass,
                feeChargeDate: this.course.feeChargeDate
            };
            if (this._imageSelected) {
                //@ts-ignore
                body['backGroundImage'] = this._imageSelected;
            }
            if (this._imageSelected) {
                //@ts-ignore
                body['thumbnail'] = this._imageSelected;
            }
            if (this.course.id) {
                //@ts-ignore
                body['id'] = this.course.id;
            }

            if (this.is_edit) {
                //await courseService.update(body);
            } else {
                await courseService.create(body);
            }
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

