import { Component } from '@angular/core';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { HttpClient } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormControl,
  Validators,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
import { UserContact } from '../../../models/UserContact.model';
@Component({
  selector: 'app-register-consultation',
  templateUrl: './register-consultation.component.html',
  styleUrl: './register-consultation.component.css',
  imports: [
    MatFormFieldModule,
    MatInputModule,
    FormsModule,
    ReactiveFormsModule,
    MatSelectModule,
    CommonModule
  ],
  standalone: true,
})
export class RegisterConsultationComponent {
  email = new FormControl('', [Validators.required, Validators.email]);
  name = new FormControl('', [Validators.required]);
  phone = new FormControl('', [Validators.required]);

  getErrorMessage() {
    if (
      this.email.hasError('required') ||
      this.name.hasError('required') ||
      this.phone.hasError('required')
    ) {
      return 'Plese enter this filed';
    }

    return this.email.hasError('email') ? 'Email is invalid' : '';
  }

  formData: UserContact = {
    email: '',
    name: '',
    phone_number: '',
    message: ''
  };
  registrationSuccess: boolean = false;

  constructor(private http: HttpClient) {}

  onSubmit() {
    this.http.post<any>('', this.formData)
      .subscribe(
        (response) => {
          console.log('Registration successful!', response);
          this.registrationSuccess = true; 
        },
        (error) => {
          console.error('Registration failed:', error);
        }
      );
  }
}
