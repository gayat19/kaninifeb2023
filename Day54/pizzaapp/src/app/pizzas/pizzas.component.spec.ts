import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PizzasComponent } from './pizzas.component';

describe('PizzasComponent', () => {
  let component: PizzasComponent;
  let fixture: ComponentFixture<PizzasComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [PizzasComponent]
    });
    fixture = TestBed.createComponent(PizzasComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
