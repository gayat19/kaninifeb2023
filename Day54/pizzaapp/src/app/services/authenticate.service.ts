import {Injectable} from '@angular/core';

@Injectable()
export class AuthenticateService{
    isAuthenticated(){
        if(localStorage.getItem("token"))
            return true;
        else 
            return false;
    }
}