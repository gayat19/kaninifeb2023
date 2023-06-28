import React from "react";
import './Product.css';

function Product(props){
    return (
        <div className="Product alert alert-info">
                     Product Id:{props.product.id}
            <br/>
            Product Name:{props.product.name}
            <br/>
            Product Price:{props.product.price}
            <br/>
            Product Quantity:{props.product.quantity}
            <br/>
        </div>
    )
}

export default Product;