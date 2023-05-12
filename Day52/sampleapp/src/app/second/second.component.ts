import { Component } from '@angular/core';

@Component({
  selector: 'app-second',
  templateUrl: './second.component.html',
  styleUrls: ['./second.component.css']
})
export class SecondComponent {
  customername:string;
  classname:string;
  classState:boolean;

  constructor() {
    this.customername = "Ramu"
    this.classname = "glyphicon glyphicon-heart-empty"
    this.classState = false;
    
  }
  buttonClicked(data:any){
    alert("Event called "+data);
  }
  showEmail(cemail:any){
    alert("Your email is "+cemail)
  }
  toggle(){
    this.classState = !this.classState;
    if(this.classState==true)
      this.classname = "glyphicon glyphicon-heart"
    else
      this.classname = "glyphicon glyphicon-heart-empty"
  }
}
