import { HttpClient } from "@angular/common/http";
import { InternModel } from "./intern.model";
import {Injectable} from '@angular/core';

@Injectable()
export class InternRegisterService{
    constructor(private httpClient:HttpClient){

    }
    createIntern(intern:InternModel){
        return this.httpClient.post("http://localhost:5156/api/User",intern);
    }
}