import React from "react";
import { useParams } from "react-router-dom";



function Data(){

    const {id} = useParams();
    return(<div>
        <h1>
            Data
        </h1>
       <h2>
            {id}
       </h2>
    </div>)
}

export default Data;