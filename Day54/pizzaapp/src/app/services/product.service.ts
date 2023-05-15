import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class ProductService{

constructor(private http:HttpClient) {
    
}

getProducts():Observable<any>{
    var header = new HttpHeaders({
        'Content-Type':'application/json',
        'Authorization':'Bearer '+localStorage.getItem("token")?.toString()
      });
      return this.http.get("http://localhost:5045/api/Product",{headers:header});
  

  
    
}
}