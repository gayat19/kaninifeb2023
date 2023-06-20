import React, { useState } from "react";

function Intern(props) {
  var [intern,setIntern] = useState(props.intern)
  return (
    <div  className="Intern alert alert-success">
      <h2>Intern Deatils</h2>
      <div>
        Intern Id : {intern.userId}
        <br/>
        Intern Name : {intern.name}
        <br/>
        Intern Age : {intern.age}
        <br/>
      </div>
    </div>
  );
}

export default Intern;