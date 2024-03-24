import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogCourseModuleComponent } from './dialog-course-module.component';

describe('DialogCourseModuleComponent', () => {
  let component: DialogCourseModuleComponent;
  let fixture: ComponentFixture<DialogCourseModuleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DialogCourseModuleComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DialogCourseModuleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
