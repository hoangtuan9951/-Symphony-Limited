import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { CommonModule } from '@angular/common';
import { AdminModule } from './admin/admin.module';
import { UserModule } from './user/user.module';
import { UserRoutingModule } from './user/user-routing.module';
import { AdminRoutingModule } from './admin/admin-routing.module';
import { AuthRoutingModule } from './auth/auth-routing.module';
import { AuthModule } from './auth/auth.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    CommonModule,
    UserRoutingModule,
    AdminRoutingModule,
    AdminModule,
    UserModule,
    AuthRoutingModule,
    AuthModule
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
