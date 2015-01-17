/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />

(function () {
    var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3],
        numbersHolder = [],
        repetitionsHolder = [],
        maxRepetition = 0,
        maxIndex;

    for (var i = 0, length = array.length; i < length; i++) {
        if (numbersHolder.indexOf(array[i]) < 0) { // fills the numbersHolder with unique numbers
            numbersHolder.push(array[i]);
        }
    }

    for (var j = 0, leng = numbersHolder.length; j < leng; j++) {
        repetitionsHolder[j] = 0; // allocates a counter for every unique number from the given array

        for (var i = 0, length = array.length; i < length; i++) {

            if (numbersHolder[j] === array[i]) {
                repetitionsHolder[j]++;
            }
        }
    }

    for (var i = 0, len = repetitionsHolder.length; i < length; i++) {
        if (maxRepetition < repetitionsHolder[i]) {
            maxRepetition = repetitionsHolder[i];
            maxIndex = i;
        }
    }

    jsConsole.writeLine("The the number " + numbersHolder[maxIndex] + " is met " + maxRepetition + " times");
}());
