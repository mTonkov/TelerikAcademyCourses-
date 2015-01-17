/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function reverse() {
    var str = "sample string",
        reversed = "";

    for (var i = str.length-1; i >= 0 ; i--) {
        reversed += str[i];
    }

    jsConsole.writeLine(reversed);
}());