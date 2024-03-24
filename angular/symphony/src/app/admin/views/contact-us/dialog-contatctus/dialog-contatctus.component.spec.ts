import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DialogContatctusComponent } from './dialog-contatctus.component';

describe('DialogContatctusComponent', () => {
  let component: DialogContatctusComponent;
  let fixture: ComponentFixture<DialogContatctusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [DialogContatctusComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(DialogContatctusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
