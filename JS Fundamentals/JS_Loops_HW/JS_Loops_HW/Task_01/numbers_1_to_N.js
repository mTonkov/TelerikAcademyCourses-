/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Loops_HW\JS_Loops_HW\js-console.js" />

// the previous row enables the use of jsConsole in the current file
function numbers() {
    var n = document.getElementById("input").value;

    for (var i = 1; i <= n; i++) {
        jsConsole.writeLine(i);
    }
}