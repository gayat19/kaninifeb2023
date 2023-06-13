import { Component } from '@angular/core';
import { TicketModel } from './ticket.model';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { TitleValidator } from './title.validation';

@Component({
  selector: 'app-raiseticket',
  templateUrl: './raiseticket.component.html',
  styleUrls: ['./raiseticket.component.css']
})
export class RaiseticketComponent {
ticket:TicketModel;
myForm:FormGroup;
  constructor(){
    this.ticket = new TicketModel();
    this.myForm = new FormGroup({
      "heading":new FormControl(null,[Validators.required,TitleValidator.checkTitle]),
      "description":new FormControl(null,[Validators.required,Validators.minLength(10)])
    });

  }
  public get heading() : any {
    return this.myForm.get("heading");
  }
  public get description() : any {
    return this.myForm.get("description");
  }
  raiseTicket(){
    if(this.myForm.valid)
      alert("Ticket raised");
    else
      alert("Please check the details");
    console.log(this.heading);
  }
}
