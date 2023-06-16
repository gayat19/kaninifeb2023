import React from "react";
import './Product.css';



function Product(props){
    // var Prod={
    //     "name":"Pencil",
    //     "price":5,
    //     "quantity":10
    // };


    return(
        <div className="alert alert-primary Product">
            <h2>Product Details</h2>
            Product Name : {props.p.name}
            <br/>
            Product Price : ${props.p.price}
            <br/>
            Product Quantity : {props.p.quantity}
            <br/>
        </div>
    );
}

export default Product;