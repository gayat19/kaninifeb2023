import React, { useState } from "react";
import './CreateIntern.css'
import { useDispatch } from "react-redux";
import { editIntern } from "../InternsSlice";
import { useSelector } from "react-redux";

function EditIntern() {
    const interns = useSelector((state)=>state.interns);
    var [intern,setIntern] = useState(interns[0]);
    
    var getIntern=(event)=>{
      console.log(event.target.value)
        for (let index = 0; index < interns.length; index++) {
           if(interns[index].userId==event.target.value)
            setIntern(interns[index])
        }
    }
  var disptach = useDispatch();
  var createIntern=()=>{
    console.log(intern)
    disptach(editIntern(intern))
  }
  return (
    <div className="CreateIntern alert alert-primary">
     <h2>Create Intern</h2>
     <div>
          <label className="form-control">
            Intern Id
          </label>
          <select onChange={getIntern} className="form-control">
            {
                interns.map((intern,index)=>{
                    return(<option key={index} value={intern.userId}>{intern.userId}</option>)
                })
            }
          </select>
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

export default EditIntern;
