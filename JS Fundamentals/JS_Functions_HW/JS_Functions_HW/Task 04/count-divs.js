/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


function count() {
    var counter = document.getElementsByTagName("div").length;

    jsConsole.writeLine("There are " + counter + " 'div' tags in the current file");
}
