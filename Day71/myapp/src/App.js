
import { useState } from 'react';
import './App.css';
import AddProduct from './components/AddProduct';
import Product from './components/Product';
import 'bootstrap/dist/css/bootstrap.css';



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
  return (
    <div>
      <h1 className='alert alert-success App'>
        Welcome!!!
      </h1>
      <AddProduct sendProduct={insertProduct}/>
      <hr/>
      {
        products.map((prod,idx)=>{
          return (<Product p={prod} key={idx}/>)
        })
      }
      {/* <Product p={product}/> */}
      <hr/>
      {
        arr.map((num,idx)=>{
          return(<li key={idx}>{num}</li>);
        })
      }
    </div>
    
  );
}

export default App;
