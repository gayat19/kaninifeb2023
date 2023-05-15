import { HttpClient } from "@angular/common/http";
import { User } from "../models/user";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class UserService{

    constructor(private http:HttpClient){

    }


    login(user:User):Observable<any>{
        console.log(user);
        return this.http.post("http://localhost:5087/api/User/Login",user);
    }
}