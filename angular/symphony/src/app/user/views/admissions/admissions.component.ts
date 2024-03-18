// home.component.ts

import { Component } from '@angular/core';
import { Admissions } from '../../models/admissions';
import { PATH_IMAGES } from '../../constant/images';
import { BENEFIT_ADMISSIONS, COURSE_ADMISSIONS, LEVEL_ADMISSIONS, PARTNER_ADMISSIONS, REASON_ADMISSIONS, TOP_ADMISSIONS } from '../../constant';

@Component({
  selector: 'app-admissions',
  templateUrl: './admissions.component.html',
  styleUrls: ['./admissions.component.scss']
})
export class AdmissionsComponent {
  pathBanner = PATH_IMAGES.admissions_banner;

  top_admissions = TOP_ADMISSIONS;
  level_admissions = LEVEL_ADMISSIONS;
  reason_admissions = REASON_ADMISSIONS;
  course_admissions = COURSE_ADMISSIONS;
  benefit_admissions = BENEFIT_ADMISSIONS;
  partner_admissions = PARTNER_ADMISSIONS;

  admissions = new Admissions();
  submitted = false;

  onSubmit() {
    console.log("admissions", this.admissions)
    this.submitted = true;
  }
}

