/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function brackets() {
    var brackets = [
    "((a+b)/5-d)",
    ")(a+b))"],
        result;

    function checkBrackets(expression) {
        var checker = 0;

        for (var i = 0; i < expression.length; i++) {
            if (expression[i] === "(") {
                checker++;
            } else if (expression[i] === ")") {
                checker--;
            }

            if (checker < 0) {
                break;
                //if the expression starts with a closing bracket, this is a wrong placement and the result will be -1
            }
        }

        if (checker === 0) {
            return "Correct placement of brackets";
        } else {
            return "Incorrect placement of brackets";
        }
    }

    for (var i = 0; i < brackets.length; i++) {
        result = checkBrackets(brackets[i]);
        jsConsole.writeLine(result + " " + brackets[i]);
    }
}());