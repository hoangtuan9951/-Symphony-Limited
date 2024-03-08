// home.component.ts

import { Component, ElementRef, ViewChild } from '@angular/core';
import { PATH_IMAGES } from '../../../constant/images';

@Component({
    selector: 'app-layout-admin',
    templateUrl: './layout.component.html',
    styleUrls: ['./layout.component.scss']
})


export class LayoutAdminComponent {
    title: string = 'hiphop';
    avatar: string = PATH_IMAGES.avatarDefault;

    @ViewChild('myElement') myElement: ElementRef;


    constructor(private elementRef: ElementRef) {
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

    ngOnDestroy(): void {

    }
}

