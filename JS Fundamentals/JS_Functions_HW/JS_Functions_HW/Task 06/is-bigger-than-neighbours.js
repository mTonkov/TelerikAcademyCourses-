/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


var initialArray = [2, 1, 4, 5, 3, 7, 5, , 3, 2, 1, 0, 25, 4, 0, 2, 1, 3, 5, 0, 59, 8, 7, 9, ];

jsConsole.writeLine("Enter a number between '0' and '" + (initialArray.length - 1) + "'");

function checkNumber() {
    var index = parseInt(document.getElementById("user-input").value);

    getResult(index);
}

function getResult(i) {
    var number = initialArray[i];

    if (i > 0 && i < initialArray.length - 1) {
        if (number > initialArray[i - 1] && number > initialArray[i + 1]) {
            jsConsole.writeLine("Yes - the chosen element is bigger than its neighbours");
        } else {
            jsConsole.writeLine("No - the chosen element is NOT bigger than its neighbours");
        }
    } else {
        jsConsole.writeLine("Element does not have two neighbours or is outside the array");
    }
}