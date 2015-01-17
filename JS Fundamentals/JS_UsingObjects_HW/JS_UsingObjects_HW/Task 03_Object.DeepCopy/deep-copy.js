/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'


 function deepcopy(obj) {
    var newObj;

    if (typeof obj == "array" || typeof obj == "object") {
        if (Array.isArray(obj)) {
            newObj = [];
        } else {
            newObj = {};
        }

        for (var prop in obj) {
            newObj[prop] = obj[prop];
        }
    } else {
        newObj = obj;
    }
    return newObj;
}

// test with objects
var bunnyIvan = {
    name: "ivan",
    legs: 4,
    color: "grey"
}

var bunnyPesho = deepcopy(bunnyIvan);
bunnyPesho.name = "pesho";
bunnyPesho.color = "white";

for (var i in bunnyIvan) {
    jsConsole.writeLine(i + ": " + bunnyIvan[i] + " ");
}

for (var i in bunnyPesho) {
    jsConsole.writeLine(i + ": " + bunnyPesho[i] + " ");
}


//test with arrays
var arr1 = [1, 2, 3],
    arr2 = deepcopy(arr1);
arr2[0] = 3;
arr2[2] = 1;
jsConsole.writeLine(arr1);
jsConsole.writeLine(arr2);

var a = 5,
    b = deepcopy(a);

jsConsole.writeLine(a);
jsConsole.writeLine(b);
