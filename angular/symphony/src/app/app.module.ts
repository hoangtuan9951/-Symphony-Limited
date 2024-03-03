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
import { FormsModule } from '@angular/forms';
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    HomeAdminComponent,
    AdmissionsComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatSlideToggleModule,
    MatMenuModule,
    MatGridListModule,
    FormsModule,
  ],
  providers: [
    provideAnimationsAsync()
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
