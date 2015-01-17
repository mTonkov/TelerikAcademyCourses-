/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />

(function a() {
    var unsortedArray = [3, 2, 3, 4, 2, 2, 47, 9, 2, 5, 7, 9, 8, 1, 0, 12],
        sortedArray = [],
        exchanger;

    for (var i = 0, length = unsortedArray.length; i < length; i++) {
        sortedArray.push(unsortedArray[i]);

        for (var j = (sortedArray.length - 1); j > 0; j--) {
            if (sortedArray[j] < sortedArray[j - 1]) {
                exchanger = sortedArray[j];
                sortedArray[j] = sortedArray[j - 1];
                sortedArray[j - 1] = exchanger;
            }
        }
    }

    jsConsole.writeLine("The sorted array is [" + sortedArray.join(", ") + "]");
}());
