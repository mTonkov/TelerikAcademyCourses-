/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.

function checkDigit() {
    var input = document.getElementById("user-input").value,
        digit;

    if (!isNaN(input)) {
        input = parseInt(input / 100);
        digit = input % 10;

        jsConsole.writeLine("Third digit is 7 -> "+ (digit===7));

    } else {
        jsConsole.writeLine("Please enter a valid integer...");
    }
    
}