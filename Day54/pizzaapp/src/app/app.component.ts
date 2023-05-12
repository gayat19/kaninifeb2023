import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'pizzaapp';
  showCart:boolean;
  constructor(){
    this.showCart = false;
  }
  toggleCart(){
    this.showCart = !this.showCart;
  }
}
