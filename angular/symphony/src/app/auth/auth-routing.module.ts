import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './views/login/login.component';


const routes: Routes = [
  {
    path: 'auth',
    children: [
      { path: 'login', component: LoginComponent, pathMatch: 'full' },
    
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AuthRoutingModule {}
