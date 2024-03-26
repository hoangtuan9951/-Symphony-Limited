import { Component, Inject } from '@angular/core';
import {
  MAT_DIALOG_DATA,
  MatDialogRef,
} from '@angular/material/dialog';
import { getBase64 } from '../../../constant';
import courseService from '../../../services/course.service';
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

    course = {
        id: 0,
        name: '',
        code: '',
        amount: 0,
        discount: '',
        description: '',
        courseDetail: '',
        thumbnail: '',
        backGroundImage: '',
        startedDate: '',
        endedDate: '',
        active: true,
        fee: 0,
        gradePass: 0,
        feeChardeDate:''

    };
    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    async onFileSelected(event: any) {
        
        const file: File = event.target.files[0];
        if (file) {
            this._imageSelected = file;

            const image = await getBase64(file);
            this.course.backGroundImage = image;
            this.course.thumbnail = image;

        }
    }
    
    ngOnInit(): void {
        if (this.data.id) {
            this.is_edit = true;
            this.course.id = this.data.id;
            this.course.name = this.data.name;
            this.course.code = this.data.code;
            this.course.amount = this.data.amount;
            this.course.discount = this.data.discount;
            this.course.description = this.data.description;
            this.course.courseDetail = this.data.courseDetail;
            this.course.backGroundImage = this.data.backGroundImage;
            this.course.startedDate = this.data.startedDate;
            this.course.endedDate = this.data.endedDate;
            this.course.active = this.data.active;
            this.course.thumbnail = this.data.thumbnail;
            this.course.fee = this.data.fee;
            this.course.gradePass = this.data.gradePass;
            this.course.feeChardeDate = this.data.feeChardeDate;

        }
    }


    async onSubmit(form: any) {

        try {

            if (this.is_edit) {
                const body = {
                    id:this.course.id,
                    name: this.course.name,
                    code: this.course.code,
                    amount: this.course.amount,
                    discount: this.course.discount,
                    description: this.course.description,
                    courseDetail: 'null',
                    backGroundImage: this._imageSelected,
                    startedDate: this.course.startedDate,
                    endedDate: this.course.endedDate,
                    active: this.course.active,
                    gradePass: this.course.gradePass,
                    thumbnail: this._imageSelected
                };

                //await courseService.update(body);
            } else {
                const body = {
                    name: this.course.name,
                    code: this.course.code,
                    amount: this.course.amount,
                    discount: this.course.discount,
                    description: this.course.description,
                    courseDetail: 'null',
                    startedDate: this.course.startedDate,
                    endedDate: this.course.endedDate,
                    active: this.course.active,
                    gradePass: this.course.gradePass,
                };
                if (this._imageSelected) {
                    //@ts-ignore
                    body['thumbnail'] = this._imageSelected;
                } 
                if (this._imageSelected) {
                    //@ts-ignore
                    body['backGroundImage'] = this._imageSelected;
                } 
                await courseService.create(body);
            }
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

