import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeAdminComponent } from './views/home/homeAdmin.component';
import { LayoutAdminComponent } from './views/layout/layout.component';

const routes: Routes = [
  {
    path: 'admin',
    children: [
      { path: 'layout', component: LayoutAdminComponent, children: [
        
      ]},
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
    exports: [RouterModule],
})
export class AdminRoutingModule {}
