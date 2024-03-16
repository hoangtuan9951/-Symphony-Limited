import { NgModule } from '@angular/core';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { AdminRoutingModule } from './admin-routing.module';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import { LayoutAdminComponent } from './views/layout/layout.component';

@NgModule({
  declarations: [HomeAdminComponent, LayoutAdminComponent],
  imports: [CommonModule, AdminRoutingModule, FormsModule],
  providers: [provideAnimationsAsync()],
  bootstrap: [LayoutAdminComponent]
})
export class AdminModule {}
