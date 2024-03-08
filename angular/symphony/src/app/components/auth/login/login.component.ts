// home.component.ts

import { Component } from '@angular/core';
import { PATH_IMAGES } from '../../../constant/images';

@Component({
    selector: 'app-login-admin',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})


export class LoginComponent {
    email: string = '';
    password: string = '';

    TYPE_ERROR = {
        REQUIRED: 'required',
        NOT_VALID: 'not_valid'
    }

    errorForm = {
        email: { isError: false, type: '' },
        password: { isError: false, type: '' },
    }

    imageLogin = PATH_IMAGES.login;

    handleChange(event: any, type: string) {
        if(type === 'email') {
            this.errorForm.email = {
                isError: false,
                type: ''
            }
        }

        if(type === 'password') {
            this.errorForm.password = {
                isError: false,
                type: ''
            }
        }
      }

    onSubmit() {
        console.log('User input:', this.email, this.password);

        if (!this.email) {
            this.errorForm.email = {
                isError: true,
                type: this.TYPE_ERROR.REQUIRED
            }
        } 

        if (!this.password) {
            this.errorForm.password = {
                isError: true,
                type: this.TYPE_ERROR.REQUIRED
            }
        }

        if (this.email) {
            const emailRegex: RegExp = /^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;
            const is_valid = emailRegex.test(this.email);

            if(!is_valid) {
                this.errorForm.email = {
                    isError: true,
                    type: this.TYPE_ERROR.NOT_VALID
                }
            }

        }

        if(this.errorForm.email.isError || this.errorForm.password.isError) return;

        console.log("valid", this.email, this.password)
    }
}

