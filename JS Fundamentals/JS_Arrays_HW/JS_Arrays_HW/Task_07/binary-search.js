/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Arrays_HW\JS_Arrays_HW\js-console.js" />

(function () {
    var sortedArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14],
        givenElement = 3,
        smallerArray = sortedArray.slice(),
        length = sortedArray.length,
        halfLength,
        elementIndex = 0;

    if (givenElement > sortedArray[0] && givenElement < sortedArray[length - 1]) {

        while (length > 1) {
            length = smallerArray.length;
            halfLength = Math.floor(length / 2);

            if (givenElement > smallerArray[halfLength]) {
                smallerArray.splice(0, (halfLength));
                elementIndex += halfLength;
            } else if (givenElement < smallerArray[halfLength]) {
                smallerArray.splice(halfLength, halfLength + 1);
            } else {
                elementIndex += halfLength;
                break;
            }
        }
        jsConsole.writeLine("The index of the searched number is '" + elementIndex + "'");
    } else {
        jsConsole.writeLine("No such number in the array!");
    }
}());
