/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Overview_HW\JS_UI_jQuery_Overview_HW\jquery-2.1.1.min.js" />

function insertBeforeOrAfter(currentObjSelector, newHtmlAsString, insertBefore) {
    insertBefore = false || insertBefore;

    if (insertBefore) {
        $(currentObjSelector).before(newHtmlAsString);
    } else {
        $(currentObjSelector).after(newHtmlAsString);
    }
}
var afterElement = document.createElement("div");
afterElement.innerText = "My";

var beforeElement = document.createElement("div");
beforeElement.innerText = "Dear";

insertBeforeOrAfter(".first", afterElement);
insertBeforeOrAfter(".second", beforeElement, true);