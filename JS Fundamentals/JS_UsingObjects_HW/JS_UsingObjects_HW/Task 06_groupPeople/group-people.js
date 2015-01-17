/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'
(function selfStarting() {

    var persons = [
        { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
        { firstname: 'Ivan', lastname: 'Petrov', age: 81 },
        { firstname: 'Pesho', lastname: 'Ivanov', age: 32 },
        { firstname: 'Ivan', lastname: 'Georgiev', age: 13 }
    ],
        groupByCriterias = ["firstname", "lastname", "age"],
        groupedPeople;


    function group(people, groupBy) {

        var associateArray = {};

        for (var person in people) {
            if (!associateArray.hasOwnProperty(people[person][groupBy])) { //checks for existing key in the array - in this case, such 'firstname'
                associateArray[people[person][groupBy].toString()] = [];//creates the unique keys in the grouped associate array
            }
        }

        for (var key in associateArray) {
            for (var person in people) {
                if (people[person][groupBy].toString() === key) {
                    associateArray[key].push(people[person].toString());
                }
            }
        }

        return associateArray;
    }

    Object.prototype.toString = function () {
        var result = [];
        for (var prop in this) {
            result += prop + ": " + this[prop] + "\n";
        }
        return jsConsole.writeLine(result);

    }

    for (var i = 0; i < groupByCriterias.length; i++) {
        groupedPeople = group(persons, groupByCriterias[i]);
        jsConsole.writeLine(groupedPeople);
    }
}());// final printing is not 100% as expected 


