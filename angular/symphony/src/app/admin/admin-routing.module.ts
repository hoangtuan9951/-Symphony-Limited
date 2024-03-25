import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { LayoutAdminComponent } from './views/layout/layout.component';
import { ManageAdminComponent } from './views/manageAdmin/manageAdmin.component';
import { ManageClassComponent } from './views/manageClass/manageClass.component';
import { UserContactComponent } from './views/userContact/userContact.component';
import { AboutUsComponent } from './views/aboutUs/aboutUs.component';
import { CourseModuleComponent } from './views/course-module/course-module.component';
import { ManagerFaqComponent } from './views/manager-faq/manager-faq.component';
import { ContactUsComponent } from './views/contact-us/contact-us.component';
import { StudentComponent } from './views/student/student.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutAdminComponent,
    children: [
      { path: 'manage-admin', component: ManageAdminComponent},
      { path: 'manage-class', component: ManageClassComponent},
      { path: 'contact', component: UserContactComponent},
      { path: 'about-us', component: AboutUsComponent},
      { path: 'manage-admin', component: ManageAdminComponent },
      { path: 'manage-class', component: ManageClassComponent },
      { path: 'contact', component: UserContactComponent },
      { path: 'about-us', component: AboutUsComponent },
      { path: 'manage-module', component: CourseModuleComponent },
      { path: 'manage-faq', component: ManagerFaqComponent },
      { path: 'contact-us', component: ContactUsComponent },
      { path: 'student', component: StudentComponent }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule { }
