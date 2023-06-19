import React, { useState } from "react";
import './Register.css'
import { useNavigate } from "react-router-dom";


function Register(){

    const navigate = useNavigate();
    const [user,setUser] = useState({
        "name": "Tomu T",
        "dateOfBirth": new Date(),
        "age": 0,
        "gender": "",
        "phone": "",
        "email": ""
    });

    var register = ()=>{
      fetch("http://localhost:5156/api/User",{
        "method":"POST",
        headers:{
            "accept": "text/plain",
            "Content-Type": 'application/json'
        },
        "body":JSON.stringify({...user,"user":{} })})
   .then(async (data)=>{
            if(data.status == 200)
            {
                var myData = await data.json();
                console.log(myData.userId)
                navigate("/data/"+myData.userId)
            }
               
      }).catch((err)=>{
        console.log(err.error)
      })
    }


    return (<div className="Register">
            <label  className="form-control">Name</label>
            <input type="text" className="form-control" onChange={(event)=>{
                setUser({...user,"name":event.target.value})
            }} />
            <label  className="form-control">Age</label>
            <input type="number" className="form-control" onChange={(event)=>{
                setUser({...user,"age":event.target.value})
            }} />
            <label  className="form-control">Date of Birth</label>
            <input type="datetime-local" className="form-control" onChange={(event)=>{
                setUser({...user,"dateOfBirth":event.target.value})
            }} />
            <label  className="form-control">Gender</label>
            <select className="form-control" onChange={(event)=>{
                setUser({...user,"gender":event.target.value})
            }}  >
                <option value="Select">Select</option>
                <option value="Male">Male</option>
                <option value="Female">Female</option>
            </select>
            <label  className="form-control">Phone</label>
            <input type="tel" className="form-control" onChange={(event)=>{
                setUser({...user,"phone":event.target.value})
            }} />
            <label  className="form-control">email</label>
            <input type="email" className="form-control" onChange={(event)=>{
                setUser({...user,"email":event.target.value})
            }} />
            <button onClick={register} className="btn btn-success">Register</button>
    </div>)
}

export default Register;