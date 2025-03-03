import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GiftsManagementComponent } from './gifts-management.component';

describe('GiftsManagementComponent', () => {
  let component: GiftsManagementComponent;
  let fixture: ComponentFixture<GiftsManagementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [GiftsManagementComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(GiftsManagementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
