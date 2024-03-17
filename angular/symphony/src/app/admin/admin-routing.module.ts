import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { LayoutAdminComponent } from './views/layout/layout.component';
import { ManageAdminComponent } from './views/manageAdmin/manageAdmin.component';


const routes: Routes = [
  {
    path: '',
    component: LayoutAdminComponent,
    children: [
      { path: 'manage-admin', component: ManageAdminComponent}
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AdminRoutingModule {}
