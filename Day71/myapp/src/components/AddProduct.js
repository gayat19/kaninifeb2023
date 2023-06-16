import React, { useState } from "react";
import './AddProduct.css';

function AddProduct(props){

   // const [name,setName] = useState();
    const [product,setProduct]=useState({
        "name":"",
        "price":0,
        "quantity":0
    })
    var changeName = (event)=>{
        // product.name=event.target.value;
        // console.log(product.name)
       // setName(event.target.value)
        setProduct({...product,"name":event.target.value})
    }   
    var insertProduct=()=>{
        props.sendProduct(product);
    }

    return (
        <div className="alert alert-primary AddProduct">
            <label className="form-control">Product Name</label>
            <input onChange={changeName} type="text" className="form-control"/>
            <label className="form-control">Product Price</label>
            <input 
            onChange={
                (event)=>{
                    setProduct({...product,"price":event.target.value})
                }
            }
             type="text" className="form-control"/>
            <label className="form-control">Product Quantity</label>
            <input onChange={(event)=>{setProduct({...product,"quantity":event.target.value})}} type="text" className="form-control"/>
            <button onClick={insertProduct} className="btn btn-primary">Add Product</button>
            <div>
                {product.name }
                <br/>
                {product.price}
                <br/>
                {product.quantity}
            </div>
        </div>
        
    );

}

export default AddProduct;