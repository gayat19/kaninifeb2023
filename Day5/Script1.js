// JavaScript source code
var customer = {
    id: 101,
    name: "Ramu",
    age: 21
}
function assignCustomerData() {
    customer.id = document.getElementById("txtCID").value * 1
    customer.name = document.getElementById("txtCName").value;
    customer.age = document.getElementById("txtCAge").value * 1
    console.log(customer);
}
function showCustomerData() {
    var myDiv = document.getElementById("msgDiv");
    myDiv.innerHTML = customer.id + "<br>" + customer.name +"<br>"+customer.age;
}