/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />

(function () {
    var firstArray = ['a', 'b', 'C', 'd', 'e', 'f'],
        secondArray = ['a', 'b', 'M', 'G'],
        loopLength,
        smallerArray;

    if (firstArray.length < secondArray.length) {
        loopLength = firstArray.length;
        smallerArray = firstArray;
    } else {
        loopLength = secondArray.length;
        smallerArray = secondArray;
    }

    for (var i = 0; i < loopLength; i++) {
        if (firstArray[i] !== secondArray[i]) {
            if (firstArray[i] < secondArray[i]) {
                smallerArray = firstArray;
                break;
            } else {
                smallerArray = secondArray;
                break;
            }            
        }
    }

    jsConsole.writeLine('The lexicographically smaller array is [' + smallerArray + ']');
}());