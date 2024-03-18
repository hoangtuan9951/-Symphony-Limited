import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BenefitPartnerComponent } from './benefit-partner.component';

describe('BenefitPartnerComponent', () => {
  let component: BenefitPartnerComponent;
  let fixture: ComponentFixture<BenefitPartnerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [BenefitPartnerComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(BenefitPartnerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
