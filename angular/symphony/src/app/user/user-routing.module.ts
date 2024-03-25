import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { AdmissionsComponent } from './views/admissions/admissions.component';
import { FAQComponent } from './views/faq/faq.component';
import { AboutUsComponent } from './views/about-us/about-us.component';
import { ContactUsComponent } from './views/contact-us/contact-us.component';
import { SearchScore } from './views/searchScore/searchScore.component';

const routes: Routes = [
  {
    path: 'user',
    children: [
      { path: 'home', component: HomeComponent, pathMatch: 'full' },
      { path: 'admissions', component: AdmissionsComponent, pathMatch: 'full' },
      { path: 'faq', component: FAQComponent, pathMatch: 'full' },
      { path: 'about', component: AboutUsComponent, pathMatch: 'full' },
      { path: 'contact', component: ContactUsComponent, pathMatch: 'full' },
      { path: 'search-score', component: SearchScore, pathMatch: 'full' },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class UserRoutingModule {}
