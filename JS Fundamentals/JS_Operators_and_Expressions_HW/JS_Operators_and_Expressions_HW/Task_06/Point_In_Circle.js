/// <reference path="c:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that checks if given print (x,  y) is within a circle K(O, 5)

var circleX = 0,
    circleY = 0,
    radius = 5;

function checkPoint() {
    var xCoord = document.getElementById('user-input-x').value,
        yCoord = document.getElementById('user-input-y').value,
        check;

    check = Math.pow(xCoord - circleX, 2) + Math.pow(yCoord - circleY, 2) < Math.pow(radius, 2);

    jsConsole.writeLine("Point is within the circle: "+ check);
}
