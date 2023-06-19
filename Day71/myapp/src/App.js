
import { useState } from 'react';
import './App.css';
import AddProduct from './components/AddProduct';
import Product from './components/Product';
import 'bootstrap/dist/css/bootstrap.css';
import Register from './components/Register';
import { BrowserRouter, Route, Routes, Link, Outlet, Router } from 'react-router-dom';
import First from './components/First';
import Home from './components/Home';
import Data from './components/Data';
import Protected from './components/Protected';
import AboutUs from './components/AboutUs';



function App() {
  var arr = [100,3534,346452,2,46];
  const [products,setProducts] = useState([{
    "name":"ABC",
    "price":20,
    "quantity":0
  },
  {
    "name":"XYZ",
    "price":10,
    "quantity":9
  }
]);
  const [product,setProduct] = useState({
    "name":"ABC",
    "price":20,
    "quantity":0
  });
  var insertProduct=(data)=>{
    // setProduct(data)
    setProducts([...products,data]);
    console.log(product);
  }
  var [isSignedIn,setSignedIn] = useState(false);


  var changeState=()=>{
      if(!isSignedIn)
        setSignedIn(true);
      else
        setSignedIn(false)
      console.log(isSignedIn)
  }
  return (
    <BrowserRouter>
    <div>
       <h1 className='alert alert-success App'>
        Welcome!!!
      </h1>
      <button className="btn btn-success" onClick={changeState}>Change</button>
      <First/>
        <Routes>
        <Route path='/' element={<AboutUs/>}/>
          <Route path='register' element={<Register/>}/>
           <Route path='add' element={<Protected isSignedIn={isSignedIn}> 
           <AddProduct/>
           </Protected>}/>
           <Route path='home' element={<Home/>}/>
           <Route path='/data/:id' element={<Data/>}/>
          
        </Routes>
      {/* <Register/>
      <AddProduct sendProduct={insertProduct}/>
      <hr/>
      {
        products.map((prod,idx)=>{
          return (<Product p={prod} key={idx}/>)
        })
      }
     <Product p={product}/> 
      <hr/>
      {
        arr.map((num,idx)=>{
          return(<li key={idx}>{num}</li>);
        })
      } */}
    </div>
    </BrowserRouter>
    
  );
}

export default App;
