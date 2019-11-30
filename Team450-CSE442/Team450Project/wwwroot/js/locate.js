
let timerHTML = document.getElementById("timerHTML"),
    sec = 0, min = 5,
    t;
var scoreBoard = document.getElementById('score');
var currentScore = 0;
var gameActive = false;
var states = Array.from(document.getElementsByClassName("us_state"));
var stateSelector = document.getElementById("stateSelector");
var currState;

//Start the state locate game mode
function startLocate() {
    document.getElementById("pre_game_module").style = "display: none;"; // Hide pre-game screen
    currState = Math.floor(Math.random() * states.length); // Get random state number between 0 and 49
    stateSelector.innerHTML = states[currState].getAttribute("state-name"); // Display current state on screen
    timerLocate(); // Start the timer for the locate mode
}

// Process user state click
function selectState(id) {
    // Get state that user clicked
    let state = document.getElementById(id);

    // Check if selected state matches prompted stae
    if (id == states[currState].getAttribute("id")) {
        state.style.fill = "green"; // Fill green if correct
        states.splice(currState, 1); // Remove from states array
        currentScore += 5; // Increase score by 5
    }
    else if (state.style.fill == "green"){ // If state was already selected, do not process anything and return
        return;
    }
    else {
        currentScore -= 2; // If incorrect state was selected, decrease score by 2
    }

    if (states.length < 1) { // If state array is empty (all states have been selected) then end the game
        locateGameOver();
    }
    else {
        currState = Math.floor(Math.random() * states.length); // Get new random state number
        stateSelector.innerHTML = states[currState].getAttribute("state-name"); // Display new stae
    }
    updateScore(); // Update the score displayed on the page
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

// Updates the score displayed on the page
function updateScore() {
    scoreBoard.innerHTML = "Score: " + currentScore;
}

updateScore();