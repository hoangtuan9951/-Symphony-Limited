import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { getBase64 } from '../../constant';

@Component({
    selector: 'about-us',
    templateUrl: './aboutUs.component.html',
    styleUrls: ['./aboutUs.component.scss'],
})

export class AboutUsComponent {
    //@ts-ignore
    detailAboutForm = {
        image_background: '',
        description: '',
    };
    private _imageSelected: File | null = null;

    async onFileSelected(event: any) {
        const file: File = event.target.files[0];
        if (file) {
            this._imageSelected = file;

            const image = await getBase64(file);
            this.detailAboutForm.image_background = image;
            console.log("🚀 ~ image:", image)
        }
    }

    constructor(private formBuilder: FormBuilder) {
    }

    ngOnInit(): void {
    
    }

    onSubmit(form: any) {
        console.log('Admin Data:', form.value);
    }

}
