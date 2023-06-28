import logo from './logo.svg';
import './App.css';
import Products from './components/Products';
import 'bootstrap/dist/css/bootstrap.css';
import AddProduct from './components/AddProduct';
import { useState } from 'react';
function App() {

  const [products,setProducts] = useState([]);
  var addProduct=(event)=>{
   setProducts([...products,event])
  }
  const people = [
    {
      name: 'James',
      age: 31,
    },
    {
      name: 'John',
      age: 45,
    },
    {
      name: 'Paul',
      age: 65,
    },
    {
      name: 'Ringo',
      age: 49,
    },
    {
      name: 'George',
      age: 34,
    }
  ];
  var [age,setAge] = useState(18);
  var addPerson=()=>{
    people.push({name:"Paulo",age:39});
  }
  return (
    <div className="App">
      <h1>Hello to react!!!</h1>
      <input type='number' onChange={(event)=>{
          setAge(event.target.value);
      }}/>
      {/* <AddProduct insertProduct={addProduct}/>
      <Products products={products} /> */}
      {
        people.filter(p=>p.age>age).map((person,index)=>{
            return(
              <div key={index}>
               Name:  {person.name} 
               <br/>
               Age : {person.age}
                </div>
            )
        })
      }
     </div>
  );
}

export default App;
