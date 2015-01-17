/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Strings_HW\JS_Strings_HW\js-console.js" />

// the first row enables the use of jsConsole

(function solve() {
    var htmlTemplate = document.getElementById('list-item').innerHTML,
        people = [{ name: 'Pesho', age: 24 },
                  { name: 'Gosho', age: 32 },
                  { name: 'Ivancho', age: 14 }],
        newHtmlContent="";

    //htmlTemplate = "<ul>" + htmlTemplate + "</ul>";
    //console.log(htmlTemplate);

    for (var i = 0; i < people.length; i++) {
        newHtmlContent += htmlCreator(people[i], htmlTemplate);
    }

    newHtmlContent = "<ul>" + newHtmlContent + "</ul>";
    console.log(newHtmlContent);
    jsConsole.writeLine(newHtmlContent);

    function htmlCreator(person, htmlTemp) {
        while (htmlTemp.indexOf("{") >= 0) {
            var htmlValueInPlaceholder = htmlTemp.substring(htmlTemp.indexOf("{") + 1,
                                                            htmlTemp.indexOf("}"));
            htmlTemp = htmlTemp.replace("{" + htmlValueInPlaceholder + "}", person[htmlValueInPlaceholder]);

            htmlTemp = htmlTemp.replace("<strong>-", "<li><strong>");
            htmlTemp = htmlTemp.replace("<-/span>", "</span></li>");
            htmlTemp = htmlTemp.replace("-", "");
            htmlTemp = htmlTemp.replace("-", "");

        }
        return htmlTemp;
    }

}())

