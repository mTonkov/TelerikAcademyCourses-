/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Functions_HW\JS_Functions_HW\js-console.js" />

// the first row enables the use of "jsConsole" in the current file


var initialArray = [2, 1, 4, 5, 3, 7, 5, 4, 6, 5, 7, 8, 2, 41, 9, 3, 5, 9, 3, 2, 1, 0, 25, 4, 0, 2, 1, 3, 5, 0, 59, 8, 7, 9, ],
    result,
    testArray = [1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5],
    testResultsArray = [0, 1, 2, 3, 4, 5];//the index equals the value in the current array and the appearances in the 'testArray'

(function testFunction() {
    var testResult;

    for (var i = 0, length = testResultsArray.length; i < length; i++) {
        testResult = count(testArray, testResultsArray[i]);

        if (testResult === testResultsArray[i]) {
            jsConsole.writeLine("Test " + i + " is successful!");
        }
    }
    jsConsole.writeLine("===============================================");
}());

function countNumber() {
    var inputNumber = parseInt(document.getElementById("user-input").value);

    result = count(initialArray, inputNumber);

    jsConsole.writeLine("The number " + inputNumber + " is contained " + result + " times in the above array");
}

function count(array, number) {
    var counter = 0;// declared on each invokation of the function to reset the value of 'counter'

    for (var i = 0, length = array.length; i < length; i++) {
        if (number === array[i]) {
            counter++;
        }
    }
    return counter;
}
