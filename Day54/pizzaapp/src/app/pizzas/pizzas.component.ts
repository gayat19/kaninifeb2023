import { Component } from '@angular/core';
import { PizzaService } from '../services/pizza.service';
import { PizzaModel } from '../models/pizzamodel';
import { Router } from '@angular/router';

@Component({
  selector: 'app-pizzas',
  templateUrl: './pizzas.component.html',
  styleUrls: ['./pizzas.component.css']
})
export class PizzasComponent {
  likeCount:number=0;
  pizzas:PizzaModel[];
  cartToggle:boolean;
  constructor(private pizzaService:PizzaService, private router:Router) {
    this.pizzas = this.pizzaService.getPizzas();
    for (let index = 0; index < this.pizzas.length; index++) {
      this.likeCount+= this.pizzas[index].likes;
      
    }
    this.cartToggle = false;
  }
  changeCount(count:any){
    this.likeCount += count;
  }
  selectPic(pizzaid:any){
    this.router.navigate(["pizzas/pic",pizzaid])
  }
  showCart(){
    //this.cartToggle = !this.cartToggle;
    this.router.navigate(["pizzas/cart"])
  }
}
