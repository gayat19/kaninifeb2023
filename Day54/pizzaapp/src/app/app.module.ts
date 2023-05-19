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
import { ShowPIcComponent } from './show-pic/show-pic.component';
import { AuthenticateService } from './services/authenticate.service';
import { AuthGuard } from './services/authGuard';

@NgModule({
  declarations: [
    AppComponent,
    PizzaComponent,
    PizzasComponent,
    CartComponent,
    LoginComponent,
    ProductsComponent,
    ShowPIcComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [PizzaService,UserService,ProductService,AuthenticateService,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
