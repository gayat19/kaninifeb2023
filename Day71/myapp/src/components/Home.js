import React from "react";
import First from "./First";
import { Outlet, useNavigate } from "react-router-dom";


function Home(){
    const navigate = useNavigate();
    var goToData = ()=>{
    navigate(-1)
    }
    
    return(<div>

        <h1>
            Home
        </h1>
        <h2>
            <button className="btn btn-primary" onClick={goToData}>Go to data</button>
        </h2>
    </div>)
}

export default Home;