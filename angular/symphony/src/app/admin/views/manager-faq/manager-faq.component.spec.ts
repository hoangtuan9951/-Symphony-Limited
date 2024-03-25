import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerFaqComponent } from './manager-faq.component';

describe('ManagerFaqComponent', () => {
  let component: ManagerFaqComponent;
  let fixture: ComponentFixture<ManagerFaqComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ManagerFaqComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ManagerFaqComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
