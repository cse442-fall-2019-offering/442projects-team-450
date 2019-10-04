// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function openModule(id) {
    let module = document.getElementById("state_module");

    module.style.display = "inline-block";

}

function exitModule() {
    let module = document.getElementById("state_module");
    module.style.display = "none";
}

function submitModule() {
    let module = document.getElementById("state_module");
    module.style.display = "none";
}
