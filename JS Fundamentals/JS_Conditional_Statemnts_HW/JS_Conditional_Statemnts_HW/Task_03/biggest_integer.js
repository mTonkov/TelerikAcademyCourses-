/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
// task: Write a script that finds the biggest of three integers using nested if statements.


function findBiggest() {
    var firstNumber = parseInt(document.getElementById("input-1").value),
        secondNumber = parseInt(document.getElementById("input-2").value),
        thirdNumber = parseInt(document.getElementById("input-3").value),
        biggest;

    if (firstNumber < secondNumber && firstNumber < thirdNumber) {
        if (secondNumber > thirdNumber) {
            biggest = secondNumber;
        } else {
            biggest = thirdNumber;
        }
    } else if (secondNumber < firstNumber && secondNumber < thirdNumber) {
        if (firstNumber > thirdNumber) {
            biggest = firstNumber;
        } else {
            biggest = thirdNumber;
        }
    } else {
        if (firstNumber > secondNumber) {
            biggest = firstNumber;
        } else {
            biggest = secondNumber;
        }
    }

    jsConsole.writeLine("The biggest number is: " + biggest);

}