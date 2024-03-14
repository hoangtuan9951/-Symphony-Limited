import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { AdminRoutingModule } from './admin-routing.module';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { LoginComponent } from './views/login/login.component';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [HomeAdminComponent, LoginComponent],
  imports: [CommonModule, AdminRoutingModule, FormsModule],
  providers: [provideAnimationsAsync()],
})
export class AdminModule {}
