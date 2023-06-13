import { Component } from '@angular/core';
import { InternModel } from './intern.model';
import { InternRegisterService } from './internregister.services';
import { LoggedInUserModel } from './loggeduser.model';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
intern:InternModel
loggedInUser:LoggedInUserModel
constructor(private internRegisterService:InternRegisterService){
  this.intern = new InternModel();
  this.loggedInUser = new LoggedInUserModel();
}
addGender(gender:any){
  this.intern.gender = gender;
}
addIntern(){
  console.log(this.intern)
  this.internRegisterService.createIntern(this.intern).subscribe(data=>{
    this.loggedInUser = data as LoggedInUserModel;
    localStorage.setItem("token",this.loggedInUser.token);
    console.log(this.loggedInUser);
  },
  err=>{
    console.log(err)
  });
}
}
