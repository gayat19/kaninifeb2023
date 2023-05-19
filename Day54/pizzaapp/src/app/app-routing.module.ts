import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CartComponent } from './cart/cart.component';
import { ProductsComponent } from './products/products.component';
import { PizzasComponent } from './pizzas/pizzas.component';
import { ShowPIcComponent } from './show-pic/show-pic.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './services/authGuard';

const routes: Routes = [
  {path:'pizzas',component:PizzasComponent,children:[
    {path:'cart',component:CartComponent},                                                                 
    {path:'pic/:pid',component:ShowPIcComponent}
  ]},
  {path:'cart',component:CartComponent,canActivate:[AuthGuard]},
  {path:'prod',component:ProductsComponent},
  {path:'login',component:LoginComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
