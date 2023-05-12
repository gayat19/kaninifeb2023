import { Component } from '@angular/core';
import { PizzaService } from '../services/pizza.service';
import { PizzaModel } from '../models/pizzamodel';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent {
  cart:PizzaModel[];
  constructor(private pizzaService:PizzaService){
    this.cart = this.pizzaService.getCart();
    
  }
}
