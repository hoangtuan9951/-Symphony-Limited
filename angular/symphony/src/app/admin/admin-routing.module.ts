import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { LoginComponent } from './views/login/login.component';

export const routes: Routes = [
  {
    path: 'admin',
    children: [
      { path: 'homeadmin', component: HomeAdminComponent },
      { path: 'login', component: LoginComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AdminRoutingModule {}
