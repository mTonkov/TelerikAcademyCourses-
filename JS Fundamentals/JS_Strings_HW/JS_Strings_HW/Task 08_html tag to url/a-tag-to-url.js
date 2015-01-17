/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function extract() {
    var text = '<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>',
        urlElement = ["[URL=", "]", "[/URL]"],
        anchorElement = ['<a href="', '">', "</a>"];

    while (text.indexOf(anchorElement[0]) >= 0) {
        for (var i = 0; i < anchorElement.length; i++) {
            text = text.replace(anchorElement[i], urlElement[i]);
        }        
    }
    
    console.log(text);
    jsConsole.writeLine(text);
})()

