import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RegisterConsultationComponent } from './register-consultation.component';

describe('RegisterConsultationComponent', () => {
  let component: RegisterConsultationComponent;
  let fixture: ComponentFixture<RegisterConsultationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [RegisterConsultationComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(RegisterConsultationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

