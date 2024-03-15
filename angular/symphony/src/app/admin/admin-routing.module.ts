import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './views/home/homeAdmin.component';

const routes: Routes = [
  {
    path: 'admin',
    children: [
      { path: 'homeadmin', component: HomeAdminComponent },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AdminRoutingModule {}
