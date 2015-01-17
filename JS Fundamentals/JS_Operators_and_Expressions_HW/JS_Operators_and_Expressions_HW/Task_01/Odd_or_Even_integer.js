/// <reference path="c:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//the 1st row is a reference to the "js-console.js" file, which gives the use of the "jsConsole" methods

//Write an expression that checks if given integer is odd or even

function oddOrEven() {
    var userInput = document.getElementById('user-input').value,
    isInt;
    isInt = parseInt(userInput);
    if (!isNaN(isInt)) {
        if (isInt % 2 === 0) {
            jsConsole.writeLine("Number is Even!");
        }
        else {
            jsConsole.writeLine("Number is Odd!");

        }

    }
    else {
        jsConsole.writeLine("The input is not a number! Please enter a valid integer number!");
        alert("The input is not a number! Please enter a valid integer number!");
    }
}
