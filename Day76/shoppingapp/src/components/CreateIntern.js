import React, { useState } from "react";
import './CreateIntern.css'
import { useDispatch } from "react-redux";
import { addIntern } from "../InternsSlice";

function CreateIntern() {
  var [intern,setIntern] = useState({
    "userId":0,
    "name":"",
    "age":0
  });
  var disptach = useDispatch();
  var createIntern=()=>{
    disptach(addIntern(intern))
  }
  return (
    <div className="CreateIntern alert alert-primary">
     <h2>Create Intern</h2>
     <div>
          <label className="form-control">
            Intern Id
          </label>
          <input className="form-control" type="number" value = {intern.userId} onChange={(event)=>{
              setIntern({...intern,"userId":event.target.value})
          }}/>
          <label className="form-control">
            Intern Name
          </label>
          <input className="form-control" type="text" value = {intern.name} onChange={(event)=>{
              setIntern({...intern,"name":event.target.value})
          }}/>
          <label className="form-control">
            Intern Age
          </label>
          <input className="form-control" type="number" value = {intern.age} onChange={(event)=>{
              setIntern({...intern,"age":event.target.value})
          }}/>
          <button className="btn btn-primary" onClick={createIntern}>Add Intern</button>
     </div>
    </div>
  );
}

export default CreateIntern;
