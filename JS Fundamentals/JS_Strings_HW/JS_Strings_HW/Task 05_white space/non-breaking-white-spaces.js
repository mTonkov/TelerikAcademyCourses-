/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function replace() {
    var input = "This is task 5 from the homework for strings.",
        replacement = "&amp;nbsp;";

    jsConsole.writeLine(replaceWhiteSpace(input, replacement));

    function replaceWhiteSpace(text, replacement) {
        var inputTextAsArray = text.split(' '),
            resultText;

        resultText = inputTextAsArray.join(replacement);
        return resultText;
    }
})()

