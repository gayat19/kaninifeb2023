import {Injectable} from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from "@angular/router";
import { Observable } from "rxjs";
import { AuthenticateService } from './authenticate.service';
import { isFormArray } from '@angular/forms';

@Injectable()
export class AuthGuard implements CanActivate{

    constructor(private authenticateService:AuthenticateService,private router:Router){

    }
   canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot)
   : Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree{
        var  isAuthorized= this.authenticateService.isAuthenticated()??false;
        if(isAuthorized == false){
            this.router.navigate(["login"])
            return false;
        }
        return isAuthorized
    }
}