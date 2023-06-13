import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from './register/register.component';
import { RaiseticketComponent } from './raiseticket/raiseticket.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './services/authentication.service';
import { PaymentComponent } from './payment/payment.component';

const routes: Routes = [
  {path:'register',component:RegisterComponent},
  {path:'ticket',component:RaiseticketComponent,canActivate:[AuthGuard] },
  {path:'login',component:LoginComponent},
  {path:'pay',component:PaymentComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
