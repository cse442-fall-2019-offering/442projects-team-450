
let timerHTML = document.getElementById("timerHTML"),
    sec = 0, min = 5,
    t;
var scoreBoard = document.getElementById('score');
var currentScore = 0;
var gameActive = false;
var states = Array.from(document.getElementsByClassName("us_state"));
var stateSelector = document.getElementById("stateSelector");
var currState;


function startLocate() {
    document.getElementById("pre_game_module").style = "display: none;"; // Hide pre-game screen
    currState = Math.floor(Math.random() * states.length);
    stateSelector.innerHTML = states[currState].getAttribute("state-name");
    timerLocate();
}

function selectState(id) {
    let state = document.getElementById(id);

    if (id == states[currState].getAttribute("id")) {
        state.style.fill = "green";
        states.splice(currState, 1);
        currentScore += 5;
    }
    else if (state.style.fill == "green"){
        return;
    }
    else {
        currentScore -= 2;
    }

    if (states.length < 1) {
        locateGameOver();
    }
    else {
        currState = Math.floor(Math.random() * states.length);
        stateSelector.innerHTML = states[currState].getAttribute("state-name");
    }
    updateScore();
}

// Activates the GAME OVER state.
function locateGameOver() {
    let module = document.getElementById("gameover_module");
    let finalSB = document.getElementById("final_score");
    //If score<0 make final score = 0
    let sign = 1;
    if (currentScore < 0) sign = 0;
    let finalScore = (currentScore + Math.floor(((min * 60) + sec) / 5)) * sign;

    var testscores = document.getElementById("scores");
    var completiontime = document.getElementById("CompletionTime");

    let timeSB = document.getElementById("completion_time");
    let finalMin = 5;
    let finalSec = 0;

    if (sec > 0) {
        finalMin--;
        finalSec = 60;
    }
    finalMin -= min;
    finalSec -= sec;

    module.style.display = "inline-block";
    finalSB.innerHTML = "Your final score is: " + finalScore;

    if (min <= 0 && sec <= 0) {
        timeSB.innerHTML = "You ran out of time!";
        completiontime.value = "5:00";
    }
    else {
        timeSB.innerHTML = "Completed in: " + finalMin + " minute(s) and " + finalSec + " second(s)!";
        completiontime.value = finalMin + ":" + finalSec;
    }
    testscores.value = finalScore;

}

// Function that increments and displays time.
function addLocate() {

    // Increments time, resets sec, min, etc. when corresponding counter reaches >= 60.

    sec--;

    if (sec < 0) {
        sec = 59;
        min--;
    }

    // Displays time.
    timerHTML.textContent = (min ? (min > 4 ? min : min) : "00") + ":" + (sec > 9 ? sec : "0" + sec);

    timerLocate();
}

//Opens module to let user enter score into leaderboard
function openScore() {
    let module = document.getElementById("enter_score_module");
    module.style = "display: inline-block;";
}

//Adds score to leaderboard
function submitScore() {
    let module = document.getElementById("enter_score_module");
    let input = module.childNodes[1].value;
    module.style = "display: none;";
}

// Applies add() function to timer.
function timerLocate() {
    if ((min <= 0 && sec <= 0) || states.length < 1) {
        locateGameOver();
    }
    else {
        t = setTimeout(addLocate, 1000);
    }
}

function updateScore() {
    scoreBoard.innerHTML = "Score: " + currentScore;
}

updateScore();