import { Component } from '@angular/core';

@Component({
  selector: 'app-payment',
  templateUrl: './payment.component.html',
  styleUrls: ['./payment.component.css']
})
export class PaymentComponent {
  user = {
    "name":"Ramu R",
    "age":21,
    "salary":2343553,
    "DOB":new Date(2000,2,20),
    "about":"This user is simply created to explain the purpose of pipes"
  }

}
