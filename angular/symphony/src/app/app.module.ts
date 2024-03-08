import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { HomeComponent } from './pages/user/home/home.component';
import { MatMenuModule} from '@angular/material/menu';
import { HeaderComponent } from './components/user/layout/header/header.component';
import { FooterComponent } from './components/user/layout/footer/footer.component';
import { HomeAdminComponent } from './pages/admin/home/homeAdmin.component';
import { MatGridListModule } from '@angular/material/grid-list';
import { AdmissionsComponent } from './pages/user/admissions/admissions.component';
import { ListCourseComponent } from './pages/user/homepages/list-course/list-course.component';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import { RegisterConsultationComponent } from './pages/user/homepages/register-consultation/register-consultation.component';
import { AboutUsComponent } from './pages/user/about-us/about-us.component';
import { ContactUsComponent } from './pages/user/contact-us/contact-us.component';
import { LoginComponent } from './components/auth/login/login.component';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    HomeAdminComponent,
    ListCourseComponent,

    AboutUsComponent,
    ContactUsComponent
    LoginComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatSlideToggleModule,
    MatMenuModule,
    MatButtonModule,
    FormsModule,
    MatGridListModule,
    RegisterConsultationComponent
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
