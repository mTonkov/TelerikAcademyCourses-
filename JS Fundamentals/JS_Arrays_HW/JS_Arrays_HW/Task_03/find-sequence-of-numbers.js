/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />

(function () {
    var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1],
        sequenceLength = 1,
        startingIndex = 0,
        bestSequenceLength = 0,
        bestStartingIndex = 0,
        sequence = [];

    for (var i = 0, length = array.length; i < length; i++) {
        if (array[i] === array[i + 1]) {
            sequenceLength++;

            if (sequenceLength === 2 && array[i] === array[i + 1]) {// sequenceLength === 2 means that a sequence is found
                startingIndex = i;
            }
        } else if (sequenceLength > 1) {
            if (sequenceLength > bestSequenceLength) {
                bestSequenceLength = sequenceLength;
                bestStartingIndex = startingIndex;
            }
            sequenceLength = 1;
        }
    }

    for (var i = bestStartingIndex; i < bestStartingIndex + bestSequenceLength; i++) {
        sequence[i - bestStartingIndex] = array[i];
    }

    jsConsole.writeLine("The maximal sequence of equal elements is {" + sequence.join(", ") + "}")
}());