import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import {HttpClientModule} from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RegisterComponent } from './register/register.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InternRegisterService } from './register/internregister.services';
import { RaiseticketComponent } from './raiseticket/raiseticket.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './services/authentication.service';
import { PaymentComponent } from './payment/payment.component';
import { CardDirectiveDirective } from './card-directive.directive';
import { LongtextPipe } from './longtext.pipe';

@NgModule({
  declarations: [
    AppComponent,
    RegisterComponent,
    RaiseticketComponent,
    LoginComponent,
    PaymentComponent,
    CardDirectiveDirective,
    LongtextPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [InternRegisterService,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
