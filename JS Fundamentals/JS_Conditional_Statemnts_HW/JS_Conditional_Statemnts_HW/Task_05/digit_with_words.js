/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
// task: Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.


var input = prompt("Please enter a digit");

input = parseInt(input);

switch (input) {
    case 0:
        alert("You entered: 'zero'"); break;

    case 1:
        alert("You entered: 'one'"); break;

    case 2:
        alert("You entered: 'two'"); break;

    case 3:
        alert("You entered: 'three'"); break;

    case 4:
        alert("You entered: 'four'"); break;

    case 5:
        alert("You entered: 'five'"); break;

    case 6:
        alert("You entered: 'six'"); break;

    case 7:
        alert("You entered: 'seven'"); break;

    case 8:
        alert("You entered: 'eight'"); break;

    case 9:
        alert("You entered: 'nine'");
        break;
    default:
        alert("You have not entered a digit!");


}

