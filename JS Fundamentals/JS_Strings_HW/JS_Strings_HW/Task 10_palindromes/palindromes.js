/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function extract() {
    var text = "ABBA lamal Telerik exe JavaScript Anna civic Academy ",
        wordsArray = [],
        loweredWordsArray = [],
            isPalindrome = true;

    console.log(text);
    jsConsole.writeLine(text);

    wordsArray = text.split(" ");
    loweredWordsArray = text.toLowerCase().split(" ");

    for (var i = 0; i < loweredWordsArray.length; i++) {
        isPalindrome = true;

        for (var j = 0, len = loweredWordsArray[i].length; j < parseInt(len / 2) ; j++) {
            if (loweredWordsArray[i][j] !== loweredWordsArray[i][len - j - 1]) {
                isPalindrome = false;
                break;
            } 
        }
        if (isPalindrome) {
            console.log(wordsArray[i]);
            jsConsole.writeLine(wordsArray[i]);
        }
    }
})()

