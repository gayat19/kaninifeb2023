import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PizzaComponent } from './pizza/pizza.component';
import { PizzaService } from './services/pizza.service';
import { PizzasComponent } from './pizzas/pizzas.component';
import { CartComponent } from './cart/cart.component';
import { LoginComponent } from './login/login.component';
import { UserService } from './services/user.service';
import { ProductService } from './services/product.service';
import { ProductsComponent } from './products/products.component';

@NgModule({
  declarations: [
    AppComponent,
    PizzaComponent,
    PizzasComponent,
    CartComponent,
    LoginComponent,
    ProductsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [PizzaService,UserService,ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
