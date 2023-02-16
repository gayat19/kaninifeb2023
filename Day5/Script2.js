
function understadingArray() {
    var scores = [10, 30, 87, 45, 100, 34, 93];
    scores.push(77);
    console.log(scores.length);
    console.log("Before");
    for (var i = 0; i < scores.length; i++) {
        console.log(scores[i])
    }
    scores.splice(2, 3);
    console.log("After splice ");
    for (var i = 0; i < scores.length; i++) {
        console.log(scores[i])
    }

}
names = [];//gloabal variable
var num1 = 100;
function understandingScope() {
    var num1 = 20;
    console.log(num1+window.num1);
}

function addName() {


    var name = document.getElementById("txtName").value;//local variable
    names.push(name);
    document.getElementById("txtName").value = "";
}
function showNames(){
    for (var i = 0; i < names.length; i++) {
        console.log(names[i])
    }
}


