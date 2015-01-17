/// <reference path="c:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that calculates trapezoid's area by given sides a and b and height h

function calculcate() {
    var sideA = parseFloat(document.getElementById('user-input-sideA').value),
        sideB = parseFloat(document.getElementById('user-input-sideB').value),
        height = parseFloat(document.getElementById('user-input-sideH').value),
        area;

    area = (( sideA + sideB )/ 2) * height;

    jsConsole.writeLine("Trapezoid's area is: " + area);
}
