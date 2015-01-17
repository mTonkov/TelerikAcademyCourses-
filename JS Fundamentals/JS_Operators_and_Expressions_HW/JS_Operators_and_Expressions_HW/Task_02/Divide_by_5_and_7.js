/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function checkDivision() {
    var input = document.getElementById("user-input").value,
        isInt = parseInt(input);

    if (!isNaN(isInt)) {
        if (isInt % 5 === 0 && isInt % 7 === 0) {
            jsConsole.writeLine(isInt + " IS divisible by 5 and 7 at the same time!");
        } else {
            jsConsole.writeLine(isInt + " is NOT divisible by 5 and 7 at the same time!");
        }
    } else {
        jsConsole.writeLine("Please enter a valid integer...");
    }
    
}