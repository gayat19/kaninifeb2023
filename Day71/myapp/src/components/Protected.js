import React from "react";
import { Navigate } from "react-router-dom";

function Protected({isSignedIn,childern}){

    if(!isSignedIn){
        return <Navigate to="/"/>
    }
    return childern;
}

export default Protected;