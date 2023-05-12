import { Component } from '@angular/core';
import { PizzaService } from '../services/pizza.service';
import { PizzaModel } from '../models/pizzamodel';

@Component({
  selector: 'app-pizzas',
  templateUrl: './pizzas.component.html',
  styleUrls: ['./pizzas.component.css']
})
export class PizzasComponent {
  likeCount:number=0;
  pizzas:PizzaModel[];
  constructor(private pizzaService:PizzaService) {
    this.pizzas = this.pizzaService.getPizzas();
    for (let index = 0; index < this.pizzas.length; index++) {
      this.likeCount+= this.pizzas[index].likes;
      
    }
  }
  changeCount(count:any){
    this.likeCount += count;
  }

}
