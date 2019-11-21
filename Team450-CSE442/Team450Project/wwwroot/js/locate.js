
function startGame() {
    document.getElementById("pre_game_module").style = "display: none;"; // Hide pre-game screen
    timer();
}

// Function that increments and displays time.
function add() {

    // Increments time, resets sec, min, etc. when corresponding counter reaches >= 60.

    sec--;

    if (sec < 0) {
        sec = 59;
        min--;
    }

    // Displays time.
    timerHTML.textContent = (min ? (min > 9 ? min : "0" + min) : "00") + ":" + (sec > 9 ? sec : "0" + sec);

    timer();
}

// Applies add() function to timer.
function timer() {
    if ((min <= 0 && sec <= 0) || stateCount == 50) {
        gameOver();
    }
    else {
        t = setTimeout(add, 1000);
    }
}

function updateScore() {
    scoreBoard.innerHTML = "Score: " + currentScore;
}

updateScore();