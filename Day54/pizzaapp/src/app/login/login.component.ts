import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { User } from '../models/user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {

user:User
  constructor(private userService:UserService) {
    this.user = new User("ramu","ramu123");
    
  }
  loginClick(){
      this.userService.login(this.user).subscribe((data)=> {
         this.user = data as User;
         localStorage.setItem("token",this.user.token);
        },(err)=>{
          // console.log(err["error"])
          alert(err["error"])
        })
  }

}
