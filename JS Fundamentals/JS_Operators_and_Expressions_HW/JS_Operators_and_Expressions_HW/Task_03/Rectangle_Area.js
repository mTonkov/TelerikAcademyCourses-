/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write an expression that calculates rectangle’s area by given width and height.

function area() {
    var width = document.getElementById("user-input-width").value,
        height = document.getElementById("user-input-height").value;

    if (!isNaN(height) && !isNaN(width)) {
        jsConsole.writeLine("Rectangle's area is: " + (width * height));
    } else {
        jsConsole.writeLine("Please enter valid numbers for width and height");
    }
}