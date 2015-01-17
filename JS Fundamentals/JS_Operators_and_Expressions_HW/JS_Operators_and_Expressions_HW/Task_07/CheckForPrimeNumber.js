/// <reference path="c:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime

function isPrime() {
    var userInput = document.getElementById('user-input').value,
        inputSqrt;

    inputSqrt = Math.sqrt(userInput);
    inputSqrt = parseInt(inputSqrt) + 1;

    for (var i = 2; i < inputSqrt; i++) {
        if (inputSqrt % i === 0) {
            jsConsole.writeLine("Number is NOT prime");
            break;
        }
        else {
            if (i === inputSqrt - 1) {
                jsConsole.writeLine("Number is prime");
            }
        }
    }
}
