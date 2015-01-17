/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
// task: Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.


function findSign() {
    var signCounter = 0,//counts the number of negative numbers
        firstNumber = document.getElementById("input-1").value,
        secondNumber = document.getElementById("input-2").value,
        thirdNumber = document.getElementById("input-3").value;

    if (firstNumber < 0) {
        signCounter++;
    }
    if (secondNumber < 0) {
        signCounter++;
    }
    if (thirdNumber < 0) {
        signCounter++;
    }

    if (signCounter % 2 === 0) { // if the count of negative signs is an odd number, the product will be negative
        jsConsole.writeLine("The sign of the product of the given real numbers will be '+' ");
    } else {
        jsConsole.writeLine("The sign of the product of the given real numbers will be '-' ");
    }
}