/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


function reverse() {
    var userInput = '' + document.getElementById("user-input").value,
        result = "",
        reversed;

    reversed = reverseNumber(userInput);

    function reverseNumber(input) {
        for (var i = input.length - 1; i >= 0 ; i--) {
            result += input[i];
        }
        return result;
    }

    jsConsole.writeLine("The last reversed number is '" + reversed + "'");
}
