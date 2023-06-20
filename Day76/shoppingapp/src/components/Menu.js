import React from "react";
import { Link } from "react-router-dom";


function Menu(){
    return(
        <nav className="navbar navbar-expand-lg navbar-light bg-light">
         
  <div className="collapse navbar-collapse" id="navbarNav">
    <ul className="navbar-nav">
      <li className="nav-item active">
        <Link to="/" className="nav-link">Home</Link>
      </li>
      <li className="nav-item">
      <Link to="/create" className="nav-link">Create</Link>
      </li>
      <li className="nav-item">
      <Link to="/list" className="nav-link">List</Link>
      </li>
      <li className="nav-item">
      <Link to="/edit" className="nav-link">Edit</Link>
      </li>
    </ul>
  </div>
</nav>
    );
}

export default Menu;