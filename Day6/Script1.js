// JavaScript source code
var myData = "<p>This is a para</p>";
//alert(myData);
////document.getElementById("div1").innerHTML = myData;
//alert("done");
function divClick() {
    document.getElementById("div1").innerHTML = myData;
}
function getElement() {
    var bodyEle = document.body;
    console.log(bodyEle);
}
function getDivs() {
    var divs = document.getElementsByTagName("div");
    
    
   // console.log(divs);
    console.log(divs[0]);
    //console.log(divs[0].children[0].innerHTML);
    console.log(divs[0].firstChild.innerHTML);
}
function addButton() {
    var bodyEle = document.body
    var myButton = document.createElement("button");
    myButton.innerHTML = "I am new";
    myButton.id = "btnNew";
    //myButton.addEventListener("click", newButtonClick)
    //myButton.addEventListener("click", function () {
    //    alert("Hey it is added.... jolly jolly");
    //})
    myButton.addEventListener("click", ()=>alert("Hey it is added.... jolly jolly"))
    bodyEle.append(myButton);
    document.getElementById("btnAdd").disabled = true;
}
function newButtonClick() {
    alert("Hey it is added.... jolly jolly");
}
