import { Injectable } from '@angular/core';
import { PizzaModel } from '../models/pizzamodel';

@Injectable({
  providedIn: 'root'
})
export class PizzaService {
pizzas:PizzaModel[];
cart:PizzaModel[];
  constructor() { 
    this.pizzas = [
      new PizzaModel(101,"Sample Pizza",250.50,3,"assets/images/Pic1.jpg",false,0),
      new PizzaModel(102,"Veg Pizza",270.99,4,"assets/images/Pic2.jpg",true,2)
    ]
    this.cart=[]
  }

  getPizzas():PizzaModel[]{
    return this.pizzas;
  }
  getCart(){
    return this.cart;
  }
  addToCart(pizza:PizzaModel){
      
      for (let index = 0; index < this.pizzas.length; index++) {
        if(this.pizzas[index].id == pizza.id)
          if(this.pizzas[index].quantity>0)
          {
            this.cart.push(pizza);
            this.pizzas[index].quantity--;
          }
        
      }
  }
}
