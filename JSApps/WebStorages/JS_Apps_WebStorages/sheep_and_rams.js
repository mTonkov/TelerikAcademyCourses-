var secretNumber = 0 | (Math.random() * (9999 - 1000) + 1000);

//Use this row to test
//alert(secretNumber);

var userInput = document.getElementById("user-guess"),
    gameInfo = document.getElementById("game-info"),
    scoresTable = document.getElementById("scores-table"),
    score = 100;

updateScores();
userInput.addEventListener("change", function checkNumbers() {
    'use strict';
    while (true) {
        var guess = userInput.value;
        userInput.value = "";

        if (guess.length !== 4 || guess[0] == '0') {
            alert("The input number should be 4-digits long and the leftmost digit should be different than '0'");
        }
        break;
    }

    var secretNumberAsString = secretNumber.toString();
    var sheep = 0,
        rams = 0;
    for (var i = 0; i < guess.length; i++) {
        if (guess[i] === secretNumberAsString[i]) {
            rams++;
        } else if (secretNumberAsString.indexOf(guess[i]) >= 0) {
            sheep++;
        }
    }

    var newGameInfo = document.createElement("p");
    if (rams == 4) {
        var nickname = prompt("You gained 10 points for your score. Enter your nickname:", "User " + (localStorage.length + 1));
        if (!localStorage[nickname]) {
            localStorage[nickname] = 0;
        }
        localStorage[nickname] = parseInt(localStorage[nickname]) + score;
        newGameInfo.innerText = "You have guessed the number " + secretNumberAsString;
        updateScores();
        window.location.reload();
    } else {
        if (rams > 0 || sheep > 0) {
            score -= 5;
            newGameInfo.innerText = "You have guessed " + rams + " rams and " + sheep + " sheep with " + guess;
        } else {
            score -= 15;
            newGameInfo.innerText = "You have NO guessed rams or sheep with " + guess;
        }
    }

    gameInfo.appendChild(newGameInfo);
});

function updateScores() {
    var storage = [];
    for (var i = 0; i < localStorage.length; i++) {
        var localKey = localStorage.key(i);
        storage.push({
            key: localKey,
            value: parseInt(localStorage.getItem(localKey))
        });
    }

    var sortedStorage = _.chain(storage)
    .sortBy("value")
    .reverse()
    .value();
    if (scoresTable.children.length>0 ){
        while (scoresTable.lastChild) {
            scoresTable.removeChild(scoresTable.lastChild);
        }
    }
    var dfrag = document.createDocumentFragment(),
        row = document.createElement('tr');

    for (var i = 0; i < sortedStorage.length; i++) {
        row.innerHTML = "<td>" + sortedStorage[i].key + "</td><td>" + sortedStorage[i].value + "pts </td>";
        dfrag.appendChild(row.cloneNode(true));
    }
    scoresTable.appendChild(dfrag);
}