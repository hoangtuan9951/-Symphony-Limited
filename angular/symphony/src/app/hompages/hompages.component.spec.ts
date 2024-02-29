import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HompagesComponent } from './hompages.component';

describe('HompagesComponent', () => {
  let component: HompagesComponent;
  let fixture: ComponentFixture<HompagesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [HompagesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(HompagesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
