import React from "react";
import { useSelector } from "react-redux";
import Intern from "./Intern";
import './ListIntern.css'

function ListIntern() {
  const interns = useSelector((state)=>state.interns);
  return (
    <div  className="alert alert-success ListIntern">
      <h2>List of Interns</h2>
      {
        interns.map((intern,index)=>{
          return (<Intern key={index} intern={intern}/>)
        })
      }
    </div>
  );
}

export default ListIntern;