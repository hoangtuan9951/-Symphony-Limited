import { Component, Inject } from '@angular/core';
import {
    MAT_DIALOG_DATA,
    MatDialogRef,
} from '@angular/material/dialog';
import adminApi from '../../../service/admin';
import { getBase64 } from '../../../constant';
import aboutUsApi from '../../../service/aboutUs';

@Component({
    selector: 'dialog-admin-component',
    templateUrl: './dialog.component.html',
    styleUrls: ['./dialog.component.scss'],
})
export class DialogManageAboutUs {
    constructor(
        public dialogRef: MatDialogRef<DialogManageAboutUs>,
        @Inject(MAT_DIALOG_DATA) public data: any,
    ) { }

    onNoClick(): void {
        this.dialogRef.close();
    }

    //@ts-ignore
    detailAboutForm = {
        image_background: '',
        description: '',
        id: 0,
    };
    private _imageSelected: File | null = null;
    private is_edit: boolean = false;

    async onFileSelected(event: any) {
        const file: File = event.target.files[0];
        if (file) {
            this._imageSelected = file;

            const image = await getBase64(file);
            this.detailAboutForm.image_background = image;
        }
    }

    ngOnInit(): void {
        if (this.data.id) {
            this.is_edit = true;
            this.detailAboutForm.description = this.data.description;
            this.detailAboutForm.image_background = this.data.backgroundImage;
            this.detailAboutForm.id = this.data.id;
        }
    }

    async onSubmit(form: any) {

        try {
            const body = { Description: this.detailAboutForm.description };
            if (this._imageSelected) {
                //@ts-ignore
                body['BackgroundImage'] = this._imageSelected
            } 
            if (this.detailAboutForm.id) {
                //@ts-ignore
                body['id'] = this.detailAboutForm.id;
            }

            if (this.is_edit) {
                await aboutUsApi.updateAboutUs(body);
            } else {
                await aboutUsApi.createAboutUs(body);
            }

            await this.data.callback();
            this.onNoClick();
        } catch (error) {
            throw new Error((error as Error).message);
        }
    }
}

