/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Loops_HW\JS_Loops_HW\js-console.js" />

function numbers() {
    var n = document.getElementById("input").value;

    for (var i = 1; i <= n; i++) {

        if (!(i % 3 === 0 && i % 7 === 0)) {
            jsConsole.writeLine(i);
        }
    }
}