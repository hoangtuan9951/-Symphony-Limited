// home.component.ts
import { Router } from '@angular/router';
import { Component } from '@angular/core';
import { PATH_IMAGES } from '../../../user/constant/images';
import authApi from '../../service/auth';
import { getToken, setHeader, setToken } from '../../../service/index';

@Component({
    selector: 'app-login-admin',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.scss']
})


export class LoginComponent {
    username: string = '';
    password: string = '';

    constructor(private router: Router) { };

    TYPE_ERROR = {
        REQUIRED: 'required',
        NOT_VALID: 'not_valid'
    }

    errorForm = {
        username: { isError: false, type: '' },
        password: { isError: false, type: '' },
    }

    imageLogin = PATH_IMAGES.login;

    handleChange(event: any, type: string) {
        if (type === 'username') {
            this.errorForm.username = {
                isError: false,
                type: ''
            }
        }

        if (type === 'password') {
            this.errorForm.password = {
                isError: false,
                type: ''
            }
        }
    }

    async onSubmit() {
        //validate
        if (!this.username) {
            this.errorForm.username = {
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

        if (this.errorForm.username.isError || this.errorForm.password.isError) return;

        //auth
        try {
            //@ts-ignore
            const token = await authApi.login({ username: this.username, password: this.password })
          
            if(token && typeof token === 'string') {
                setHeader('Authorization', token)
                setToken(token)
                this.router.navigate(['/admin/manage-admin']);
            }
          
        } catch (error) {
            //@ts-ignore
            throw new Error(error)
        }


    }

    ngOnInit(): void {
        // Thực hiện các hành động sau khi component được khởi tạo
        const token = getToken();
        if(token) {
            this.router.navigate(['/admin/manage-admin']);
        }
    }
}

