import { Component, DoCheck, OnChanges, OnInit, SimpleChanges } from '@angular/core';
import { PizzaService } from '../services/pizza.service';
import { PizzaModel } from '../models/pizzamodel';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-show-pic',
  templateUrl: './show-pic.component.html',
  styleUrls: ['./show-pic.component.css']
})
export class ShowPIcComponent implements OnInit,OnChanges,DoCheck
 {

  pizzas:PizzaModel[];
  pizzaId:number=0;
  pizza:PizzaModel=new PizzaModel();
  constructor(private pizzaService:PizzaService,private activeRoute:ActivatedRoute){
    this.pizzas = this.pizzaService.getPizzas();
    // this.pizzaId = this.activeRoute.snapshot.params["pid"];
    // for (let index = 0; index < this.pizzas.length; index++) {
    //  if(this.pizzas[index].id==this.pizzaId)
    //     this.pizza = this.pizzas[index];
    // }
    // this.activeRoute.params.subscribe(p=>{
    //   this.pizzaId=p["pid"];
    //   for (let index = 0; index < this.pizzas.length; index++) {
    //      if(this.pizzas[index].id==this.pizzaId)
    //         this.pizza = this.pizzas[index];
    // }
  // });
  }
  ngDoCheck(): void {
        this.pizzaId = this.activeRoute.snapshot.params["pid"];
    for (let index = 0; index < this.pizzas.length; index++) {
     if(this.pizzas[index].id==this.pizzaId)
        this.pizza = this.pizzas[index];
    }
  }
  ngOnChanges(changes: SimpleChanges): void {
    console.log("Changes called")
  }
  ngOnInit(): void {
    console.log("Init called")
  }

}
