/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_UsingObjects_HW\JS_UsingObjects_HW\js-console.js" />
// previous row enables the use of 'jsConsole'

var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Bay', lastname: 'Ivan', age: 81 },
    { firstname: 'Pesho', lastname: 'Ivanov', age: 26 },
    { firstname: 'Ivan', lastname: 'Georgiev', age: 13 }
],
    minAge = people[0].age,
    youngestIndex;

for (var person in people) {
    if (people[person].age < minAge) {
        youngestIndex = person;
    }
}

jsConsole.writeLine("Youngest person in array is " + people[youngestIndex].firstname + " " + people[youngestIndex].lastname);
