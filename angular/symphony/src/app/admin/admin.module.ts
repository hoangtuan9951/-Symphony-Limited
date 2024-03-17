import { NgModule } from '@angular/core';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { AdminRoutingModule } from './admin-routing.module';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { LayoutAdminComponent } from './views/layout/layout.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
import { ManageAdminComponent } from './views/manageAdmin/manageAdmin.component';
import { DialogManageAdmin } from './views/manageAdmin/dialog/dialog.component';
import {
  MatDialogTitle,
  MatDialogContent,
  MatDialogActions,
  MatDialogClose,
} from '@angular/material/dialog';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';

@NgModule({
  declarations: [
    HomeAdminComponent,
    LayoutAdminComponent,
    ManageAdminComponent,
    DialogManageAdmin,
  ],
  imports: [
    CommonModule,
    AdminRoutingModule,
    FormsModule,
    MatPaginatorModule,
    MatTableModule,
    MatDialogTitle,
    MatDialogContent,
    MatDialogActions,
    MatDialogClose,
    MatButtonModule,
    MatInputModule,
    MatFormFieldModule,
  ],
  providers: [provideAnimationsAsync()],
  bootstrap: [LayoutAdminComponent],
})
export class AdminModule {}
