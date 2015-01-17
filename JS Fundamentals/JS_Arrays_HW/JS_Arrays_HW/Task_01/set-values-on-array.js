/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />
//the previous row enables usage of the "jsConsole" methods in the current file

(function () {
    var array = [];

    for (var i = 0; i < 20; i++) {
        array[i] = i * 5;
    }

    jsConsole.writeLine('['+array+']');
}());