// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let currentID = null;

function openModule(id) {
    let module = document.getElementById("state_module");
    let userInput = document.getElementById("input_textbox");
    let state = document.getElementById(id);
    currentID = id;

    module.style.display = "inline-block";
    userInput.value = "";
    state.style.fill = "yellow";
}

function exitModule() {
    let module = document.getElementById("state_module");
    let state = document.getElementById(currentID);

    module.style.display = "none";
    //state.style.fill = "red";
}

function submitModule() {
    let module = document.getElementById("state_module");
    let userInput = document.getElementById("input_textbox");
    let state = document.getElementById(currentID);

    module.style.display = "none";
    let userAnswer = userInput.value;
    state.style.fill = "green";
}
