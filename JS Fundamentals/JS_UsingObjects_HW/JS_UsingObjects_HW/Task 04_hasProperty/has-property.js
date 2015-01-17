/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'

var firstObject = {
    name: "full name",
    age: 30,
    watch: 2
    },
    secondObject = {
    name: "fullName",
    age: 35,
    },
    searchedProperty = "watch";

if (hasProperty(secondObject, searchedProperty)) {
    jsConsole.writeLine("There IS a property named '" + searchedProperty + "'");
} else {
    jsConsole.writeLine("There is NO property named '" + searchedProperty + "'");
}



function hasProperty(obj, property) {
    for (var prop in obj) {
        if (prop == property) {
            return true;
        }
    }
    return false;
}