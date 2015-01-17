/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Loops_HW\JS_Loops_HW\js-console.js" />

(function minMax() {
    var sequence = [5, 6, 3, 1, 9, 5, 65, 2, 4, -6, 0],
        min = sequence[0],
        max = sequence[0];

    for (var i = 0, len = sequence.length; i < len; i++) {
        if (min > sequence[i]) {
            min = sequence[i];
        }
        if (max < sequence[i]) {
            max = sequence[i];
        }
    }

    jsConsole.writeLine("The predefined sequence is: " + sequence);
    jsConsole.writeLine("The min number is " + min + " and the max number is " + max);
}());