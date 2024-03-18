import { Component } from '@angular/core';
import { BENEFIT_ADMISSIONS, PARTNER_ADMISSIONS } from '../../constant';

@Component({
  selector: 'app-benefit-partner',
  templateUrl: './benefit-partner.component.html',
  styleUrl: './benefit-partner.component.css'
})
export class BenefitPartnerComponent {
  benefit_admissions = BENEFIT_ADMISSIONS;
  partner_admissions = PARTNER_ADMISSIONS;
}
