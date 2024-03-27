import { NgModule } from '@angular/core';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { MatMenuModule} from '@angular/material/menu';
import { MatGridListModule } from '@angular/material/grid-list';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import { HomeComponent } from './views/home/home.component';
import { HeaderComponent } from './components/layout/header/header.component';
import { FooterComponent } from './components/layout/footer/footer.component';
import { ListCourseComponent } from './views/homepages/list-course/list-course.component';
import { AboutUsComponent } from './views/about-us/about-us.component';
import { ContactUsComponent } from './views/contact-us/contact-us.component';
import { AdmissionsComponent } from './views/admissions/admissions.component';
import { BenefitPartnerComponent } from './views/benefit-partner/benefit-partner.component';
import { UserRoutingModule } from './user-routing.module';
import { RegisterConsultationComponent } from './views/homepages/register-consultation/register-consultation.component';
import { CommonModule, DatePipe } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { SearchScore } from './views/searchScore/searchScore.component';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatTableModule } from '@angular/material/table';
@NgModule({
  declarations: [
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    ListCourseComponent,
    AboutUsComponent,
    ContactUsComponent,
    AdmissionsComponent,
    BenefitPartnerComponent,
    SearchScore,
  ],
  imports: [
    UserRoutingModule,
    MatSlideToggleModule,
    MatMenuModule,
    MatButtonModule,
    FormsModule,
    MatGridListModule,
    RegisterConsultationComponent,
    CommonModule,
    HttpClientModule,
    MatPaginatorModule,
    MatTableModule,
  ],
  providers: [
    provideAnimationsAsync(),
    DatePipe 
  ],
  exports: [HeaderComponent, FooterComponent],

})
export class UserModule { }
