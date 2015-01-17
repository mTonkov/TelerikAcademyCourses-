/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Loops_HW\JS_Loops_HW\js-console.js" />

(function lexicographical_smallest_largest() {

    function getObjectProperties(object) {
        var arrayOfProperties = [];

        for (var prop in object) {
            arrayOfProperties.push(prop);
        }

        return arrayOfProperties;
    }

    var propertiesOfDocument = getObjectProperties(document),
        propertiesOfWindow = getObjectProperties(window),
        propertiesOfNavigator = getObjectProperties(navigator),
        lastIndex = propertiesOfDocument.length - 1;

    propertiesOfDocument.sort();
    jsConsole.writeLine("The lexicographically smallest property of 'document' is '" + propertiesOfDocument[0] + "' and the largest is '" + propertiesOfDocument[lastIndex] +"'");

    propertiesOfWindow.sort();
    lastIndex = propertiesOfWindow.length - 1;
    jsConsole.writeLine("The lexicographically smallest property of 'window' is '" + propertiesOfWindow[0] + "' and the largest is '" + propertiesOfWindow[lastIndex] + "'");

    propertiesOfNavigator.sort();
    lastIndex = propertiesOfNavigator.length - 1;
    jsConsole.writeLine("The lexicographically smallest property of 'navigator' is '" + propertiesOfNavigator[0] + "' and the largest is '" + propertiesOfNavigator[lastIndex] + "'");
}());