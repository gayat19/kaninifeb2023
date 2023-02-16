var customer = {
    id: 0,
    name: "",
    age: 0
};
var customers = [];
function addCustomerData() {
    customer = new Object();
    customer.id = document.getElementById("txtCID").value
    customer.name = document.getElementById("txtCName").value;
    customer.age = document.getElementById("txtCAge").value
    customers.push(customer);
}
function showCustomerData() {
    for (var i = 0; i < customers.length; i++) {
        data ="Customer ID : " + customers[i].id + " Customer Name : " + customers[i].name + " Customer Age : " + customers[i].age;
        console.log(data);
    }
}