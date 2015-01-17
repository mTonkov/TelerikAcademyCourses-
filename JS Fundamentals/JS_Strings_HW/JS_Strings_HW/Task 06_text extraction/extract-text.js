/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function extract() {
    var html = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>",
        isBetweenTags = false,
        result;

    function extractFromHtml(htmlText) {
        var resultText = "";

        for (var i = 0, len = html.length; i < len; i++) {
            if (htmlText[i] === "<") {
                isBetweenTags = true;
            }
            if (htmlText[i] === ">") {
                isBetweenTags = false;
            }
            if (!isBetweenTags && htmlText[i] !== ">") {
                resultText += htmlText[i];
            }
        }
        return resultText;
    }

    result = extractFromHtml(html);
    jsConsole.writeLine(result);
})()

