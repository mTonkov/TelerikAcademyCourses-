/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
// task: Sort 3 real values in descending order using nested if statements.


function sort() {
    var firstNumber = parseInt(document.getElementById("input-1").value),
        secondNumber = parseInt(document.getElementById("input-2").value),
        thirdNumber = parseInt(document.getElementById("input-3").value),
        biggest;

    if (firstNumber > secondNumber && firstNumber > thirdNumber) {
        jsConsole.writeLine(firstNumber);
        if (secondNumber > thirdNumber) {
            jsConsole.writeLine(secondNumber);
            jsConsole.writeLine(thirdNumber);
        } else {
            jsConsole.writeLine(thirdNumber);
            jsConsole.writeLine(secondNumber);
        }
    } else if (secondNumber > firstNumber && secondNumber > thirdNumber) {
        jsConsole.writeLine(secondNumber);
        if (firstNumber > thirdNumber) {
            jsConsole.writeLine(firstNumber);
            jsConsole.writeLine(thirdNumber);
        } else {
            jsConsole.writeLine(thirdNumber);
            jsConsole.writeLine(firstNumber);
        }
    } else {
        jsConsole.writeLine(thirdNumber);
        if (firstNumber > secondNumber) {
            jsConsole.writeLine(firstNumber);
            jsConsole.writeLine(secondNumber);
        } else {
            jsConsole.writeLine(secondNumber);
            jsConsole.writeLine(firstNumber);
        }
    }
}