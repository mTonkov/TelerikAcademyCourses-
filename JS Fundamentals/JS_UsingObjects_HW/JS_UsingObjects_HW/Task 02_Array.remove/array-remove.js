/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'


Array.prototype.remove = function (element) {
    for (var i = 0, len = this.length; i < len; i++) {
        if (this[i] === element) {
            this.splice(i, 1);
        }
    }
    return this;
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

function removeElement() {
    var input = document.getElementById("input").value,
        isInputAString = document.getElementById("checkbox").checked;

    if (!isInputAString) {
        input = parseInt(input);
    }
    arr.remove(input);

    jsConsole.writeLine(arr);
}
