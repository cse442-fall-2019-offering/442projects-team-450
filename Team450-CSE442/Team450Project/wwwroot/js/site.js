// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
let currentID = null;
tries_left = 3;

function openModule(id) {
    let module = document.getElementById("state_module");
    if (module.style.display == "inline-block") return;
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
    state.style.fill = "#d3d3d3";
}

function submitModule() {
    let module = document.getElementById("state_module");
    let userInput = document.getElementById("input_textbox").value;
    let state = document.getElementById(currentID);
    if (userInput.toLowerCase() != state.getAttribute("state-name").toLowerCase()) {
        tries_left--;
        if (tries_left < 1) {
            module.style.display = "none";
            state.style.fill = "red";
        }
        else {
            document.getElementById("tries_left").innerHTML = "Number of Attempts left: " + tries_left;
        }
    }
    else {
        module.style.display = "none";
        state.style.fill = "green";
        tries_left = 3;
    }
}
