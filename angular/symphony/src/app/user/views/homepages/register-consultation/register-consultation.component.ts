import { Component } from '@angular/core';
import { MatSelectModule } from '@angular/material/select';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import {
  FormControl,
  Validators,
  FormsModule,
  ReactiveFormsModule,
} from '@angular/forms';
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
      return 'Vui lòng nhập dữ liệu';
    }

    return this.email.hasError('email') ? 'Định dạng mail chưa đúng' : '';
  }
}
