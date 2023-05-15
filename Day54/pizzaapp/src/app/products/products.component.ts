import { Component } from '@angular/core';
import { ProductService } from '../services/product.service';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent {
  products:any;
  constructor(private productService:ProductService) {
     
  }
  getProducts(){
    this.productService.getProducts().subscribe((data)=>{
      this.products = data;
    })
  }
}
