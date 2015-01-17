/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
//the previous row enables the use of the "js-console" methods in the current JavaScript file


// task: Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.


function exchangeVars() {
    var smallerInt = document.getElementById("input-1").value,
        biggerInt = document.getElementById("input-2").value,
        exchanger;

    if (smallerInt > biggerInt) {
        exchanger = smallerInt;
        smallerInt = biggerInt;
        biggerInt = exchanger;
    }

    jsConsole.writeLine("The smaller integer is: " + smallerInt);
    jsConsole.writeLine("The bigger integer is: " + biggerInt);
}