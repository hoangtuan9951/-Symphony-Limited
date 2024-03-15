import { NgModule } from '@angular/core';

import { CommonModule } from '@angular/common';
import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './views/login/login.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [LoginComponent],
  imports: [AuthRoutingModule, CommonModule, FormsModule],
  providers: [provideAnimationsAsync()],
})
export class AuthModule {}
