/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


function getDigit() {
    var input = document.getElementById("user-input").value,
        lastDigit,
        result;

    lastDigit = input % 10;
    result = digitToText(lastDigit);
    jsConsole.writeLine("The last digit of the number is '" + result + "'");

    function digitToText(digit) {

        switch (digit) {
            case 0:
                return "zero";
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "There is an invalid digit"
        }
    }
}
