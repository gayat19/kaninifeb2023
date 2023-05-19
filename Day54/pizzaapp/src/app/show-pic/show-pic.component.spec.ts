import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowPIcComponent } from './show-pic.component';

describe('ShowPIcComponent', () => {
  let component: ShowPIcComponent;
  let fixture: ComponentFixture<ShowPIcComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ShowPIcComponent]
    });
    fixture = TestBed.createComponent(ShowPIcComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
