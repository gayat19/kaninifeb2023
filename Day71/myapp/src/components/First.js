
function First(props) {
  var num = 100;
  
  
    return (
    <div>
      {props.p.name}
      <input type="text" value={props.p.price}/>
    </div>
    
  );
}

export default First;
