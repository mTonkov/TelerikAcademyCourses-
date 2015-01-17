/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function solve() {

    var text = "{0}, {1}, {0} text {2}",
        args = '1, Pesho, Gosho';

    var newstring = stringFormat("{0} + {4} = {5}", 1, 2, 3, 4, 5, 6);

    console.log(newstring);
    function stringFormat(pattern, arg0, arg1) {

        while (pattern.indexOf("{") >= 0) {
            placeHolderIndex = parseInt(pattern.substring(pattern.indexOf("{") + 1, pattern.indexOf("}")));
            pattern = pattern.replace("{" + placeHolderIndex + "}", arguments[placeHolderIndex + 1]);
        }
        return pattern;
    }
}())

