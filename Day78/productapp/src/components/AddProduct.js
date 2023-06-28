import React from "react";
import './AddProduct.css'
import { useState } from "react";

function AddProduct(props){
    var [product,setProduct] = useState({
        "id":0,
        "name":"",
        "price":0,
        "quantity":0
    })

    var addProduct=()=>{
        props.insertProduct(product)
    }


    return(<div className="alert-alert-success AddProduct">
        <label className="form-control">Product Id</label>
        <input type="number" 
        onChange={(event)=>{
           setProduct({...product,"id":event.target.value})
        }}
        className="form-control"/>
        <label className="form-control">Product Name</label>
        <input type="text" 
         onChange={(event)=>{
            setProduct({...product,"name":event.target.value})
         }}
          className="form-control"/>
        <label className="form-control">Product Price</label>
        <input type="number"
         onChange={(event)=>{
            setProduct({...product,"price":event.target.value})
         }}
          className="form-control"/>
        <label className="form-control">Product Quantity</label>
        <input type="number"  onChange={(event)=>{
           setProduct({...product,"quantity":event.target.value})
        }}
         className="form-control"/>
        <button className="btn btn-success" onClick={addProduct}>Add Product</button>
    </div>)
}

export default AddProduct;