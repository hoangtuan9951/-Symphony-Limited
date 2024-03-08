import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './pages/user/home/home.component';
import { AboutComponent } from './pages/user/about/about.component';
import { HomeAdminComponent } from './pages/admin/home/homeAdmin.component';
import { AdmissionsComponent } from './pages/user/admissions/admissions.component';
import { FAQComponent } from './pages/user/faq/faq.component';
import { LoginComponent } from './components/auth/login/login.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'about', component: AboutComponent },
  { path: 'admin', component: HomeAdminComponent },
  { path: 'admissions', component: AdmissionsComponent },
  { path: 'faq', component: FAQComponent },
  { path: 'login', component: LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { 
}
