/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the previous rows enable the use of "jsConsole" and the function from the previous task in the current file

(function findFirstBiggerThanNeighbours() {
    var initialArray = [2, 1, 4, 5, 3, 7, 5, , 3, 2, 1, 0, 25, 4, 0, 2, 1, 3, 5, 0, 59, 8, 7, 9, ],
        result = -1;

    for (var i = 0, length = initialArray.length; i < length; i++) {
        if (getResult(i)) {
            result = i;
            break;
        }
    }

    if (result > -1) {
        jsConsole.writeLine("The first element bigger than its neighbours is on position '" + result + "'");
    } else {
        jsConsole.writeLine(result);
    }

    function getResult(i) {
        var number = initialArray[i];

        if (i > 0 && i < initialArray.length - 1) {
            if (number > initialArray[i - 1] && number > initialArray[i + 1]) {
                return true;
            } else {
                return false;
            }
        } else {
            return false;
        }
    }
}());