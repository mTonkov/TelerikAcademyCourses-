/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Operators_and_Expressions_HW\JS_Operators_and_Expressions_HW\js-console.js" />

//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

function checkBit() {
    var input = document.getElementById("user-input").value,
        bit;

    if (!isNaN(input)) {
        input = input >> 3;
        bit = input & 1;
                
        jsConsole.writeLine("Third bit is "+ bit);
    } else {
        jsConsole.writeLine("Please enter a valid integer...");
    }
    
}