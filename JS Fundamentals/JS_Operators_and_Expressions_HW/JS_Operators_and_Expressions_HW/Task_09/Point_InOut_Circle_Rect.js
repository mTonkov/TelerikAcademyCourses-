/// <reference path="c:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).


var circleX = 1,
    circleY = 1,
    radius = 3,
    rectTop = 1,
    rectLeft = -1,
    rectWidth = 6,
    rectHeight = 2;

function checkPoint() {
    var xCoord = document.getElementById('user-input-x').value,
        yCoord = document.getElementById('user-input-y').value,
        checkCircle,
        checkRect;

    checkCircle = Math.pow(xCoord - circleX, 2) + Math.pow(yCoord - circleY, 2) <= Math.pow(radius, 2);
    checkRect = (xCoord <= (rectLeft + rectWidth) && xCoord >= rectLeft) && (yCoord <= rectTop && yCoord >= (rectTop - rectHeight));
    //calculations in the previous row: X of the point is between the right and left sides of the rectangle, and Y is between the top and bottom sides.
    // result: "true" if point is insidethe other figures

    function resultChecker(check) {
        var result;
        if (check) {
            result = "Inside";
        }
        else {
            result = "Outside";
        }
        return result;
    }
    jsConsole.writeLine("Point is " + resultChecker(checkCircle) + " the Circle and " + resultChecker(checkRect) + " the Rectangle ");
}
