// home.component.ts

import { Component, ElementRef, ViewChild } from '@angular/core';
import { PATH_IMAGES } from '../../constant/images';
import { MENU_ADMIN } from '../../constant/index';
import { getToken } from '../../../service/index';
import { Router } from '@angular/router';
import adminApi from '../../service/admin';

@Component({
    selector: 'app-layout-admin',
    templateUrl: './layout.component.html',
    styleUrls: ['./layout.component.scss']
})


export class LayoutAdminComponent {
    avatar: string = PATH_IMAGES.avatarDefault;
    menu_admin = MENU_ADMIN;
    userInfo: infoUser | null = null;

    @ViewChild('myElement') myElement: ElementRef;

    handleGetUserInfo = async () => {
        try {
            this.userInfo = await adminApi.getUserInfo();
        } catch(error) {
            console.log("error", error)
        }
        
    }

    constructor(private elementRef: ElementRef, private router: Router) {
        this.myElement = this.elementRef.nativeElement;
    }

    ngAfterViewInit() {
        const menu = this.myElement.nativeElement;
        const listChildren = Array.from(menu.children)

        //@ts-ignore
        listChildren.forEach((item: HTMLDivElement) => {
            item.addEventListener('click', (e) => {
                //@ts-ignore
                listChildren.forEach((otherChild: HTMLElement) => {
                    otherChild.classList.remove('active');
                });

                item.classList.add('active');
            })
        })
    }

    ngOnInit(): void {
        const token = getToken();
        
        if(!token) {
            this.router.navigate(['/auth/login']);
        }

        this.handleGetUserInfo()
    }
}