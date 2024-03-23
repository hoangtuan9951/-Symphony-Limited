// home.component.ts

import { Component, OnInit } from '@angular/core';
import { LIST_MENU } from '../../../constant';
import { CourseModuleMenuModel } from '../../../models/course.model';
import { CourseService } from '../../../services/course.service';

@Component({
  selector: 'app-header-user',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent  implements OnInit {
  list_menu: CourseModuleMenuModel[] | undefined;

  constructor(private dataService: CourseService) {}

  ngOnInit() {
    this.getListData();
  }

  getListData() {
    this.dataService.getMenuCourseData().subscribe((response) => {
      this.list_menu = response;
      console.log(this.list_menu);
    });
  }
}


