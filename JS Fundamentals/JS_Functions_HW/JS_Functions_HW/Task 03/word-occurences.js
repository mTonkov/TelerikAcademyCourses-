/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


function count() {
    var userTextInput = "" + document.getElementById("user-input-text").value,
        userWordInput = "" + document.getElementById("user-input-word").value ||
                        document.getElementById("user-input-word").getAttribute("placeholder"),
        foundIndexes = [],
        isCaseSensitive = document.getElementById("user-input-checkbox").checked,
        textAsArray = [],
        textSeparators = [",", ".", "-", "(", ")"];

    if (isCaseSensitive) {
        getWordOccurences(userTextInput, userWordInput, isCaseSensitive);
    } else {
        getWordOccurences(userTextInput, userWordInput);
    }

    function getWordOccurences(textByUser, wordByUser, caseSensitive) {
        switch (arguments.length) {
            case 2:
                textByUser = textByUser.toLowerCase();
                wordByUser = wordByUser.toLowerCase();

                foundIndexes = getWordIndexes(textByUser, wordByUser);
                break;
            case 3:
                foundIndexes = getWordIndexes(textByUser, wordByUser);
                break;
            default:
                jsConsole("No 'getWordOccurences' overload takes " + arguments.length + " arguments");
        }
        printOccurences(wordByUser, foundIndexes);
    }

    function convertTextToArrayOfWords(textInput, separators) { 
        for (var i = 0; i < separators.length; i++) {
            textInput.replace(separators[i], " ");
        }//instead of using regular expression, I replace non-alphabet symbols with 'space' and then split by 'space'
        return textInput.split(" ");
    }

    function getWordIndexes(text, word) {
        var occurences = [];
        textAsArray = convertTextToArrayOfWords(text, textSeparators);

        for (var i = 0, len = textAsArray.length; i < len; i++) {
            if (textAsArray[i] === word) {
                occurences.push(i + 1); //it is 'i+1' because (i) is the index, but the position is (i+1)
            }
        }
        return occurences;
    }

    function printOccurences(word, indexes) {
        if (indexes.length > 0) {
            jsConsole.writeLine("The word '" + word + "' is located on positions " + indexes.join(", "));
        } else {
            jsConsole.writeLine("There is no '" + word + "' word");
        }
    }
}
