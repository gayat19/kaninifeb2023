import { Component, EventEmitter, Input, Output } from '@angular/core';
import { PizzaModel } from '../models/pizzamodel';
import { PizzaService } from '../services/pizza.service';

@Component({
  selector: 'app-pizza',
  templateUrl: './pizza.component.html',
  styleUrls: ['./pizza.component.css']
})
export class PizzaComponent {
  @Input() pizza:PizzaModel;//Parent to child communication
  @Output() likeChange:EventEmitter<number>;//child to parent communication
  favClass:string;

  constructor(private pizzaService:PizzaService) {
    //this.pizza = new PizzaModel(101,"Sample Pizza",250.50,0,"assets/images/Pic1.jpg",false,0);
    this.pizza = new PizzaModel();
    this.favClass=this.pizza.favStatus?"bi bi-heart-fill":"bi bi-heart";
    this.likeChange = new EventEmitter<number>();
}


  favToggle(){

    this.pizza.favStatus = !this.pizza.favStatus;
    this.favClass=this.pizza.favStatus?"bi bi-heart-fill":"bi bi-heart";
  }

  incrementLikes(){
    this.pizza.likes++;
    this.likeChange.emit(1);
  }
  buy(){
    var myPizza = new PizzaModel();
    myPizza.id = this.pizza.id;
    myPizza.name = this.pizza.name;
    myPizza.price = this.pizza.price;
    myPizza.pic = this.pizza.pic;
    myPizza.quantity = 1;

    this.pizzaService.addToCart(myPizza);
  }


}
