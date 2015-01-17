/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function search() {

    var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.",
        searchedFor = "in",
        result;


    function countSubstring(textString, subString) {
        var counter = 0,
            index = 0;

        textString = textString.toLowerCase();
        subString = subString.toLowerCase();

        while (index >= 0 ) {
            index = textString.indexOf(subString, index);

            if (index >= 0) {
                counter++;
                index++;
            }
        }
        return counter;
    }

    result = countSubstring(text, searchedFor);

    console.log("The substring '" + searchedFor + "' is countained " + result + " times");
   // jsConsole.writeLine("The substring '" + searchedFor + "' is countained " + result + " times");
}())

