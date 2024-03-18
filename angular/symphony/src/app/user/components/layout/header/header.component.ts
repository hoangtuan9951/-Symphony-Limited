// home.component.ts

import { Component } from '@angular/core';
import { LIST_MENU } from '../../../constant';

@Component({
  selector: 'app-header-user',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent {
  title = 'my-app';
  list_menu = LIST_MENU
}

