import React from "react";
import './Products.css';
import Product from './Product'


function Products(props){

    return(<div>
            <h2>Product Details</h2>  
            {
                props.products.map((prod,index)=>{
                    return(<Product product={prod} key={index}/>)
                })
            }
          
    </div>)
}

export default Products;