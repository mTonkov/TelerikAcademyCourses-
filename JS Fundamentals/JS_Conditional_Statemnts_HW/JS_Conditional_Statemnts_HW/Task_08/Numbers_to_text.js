/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
/* task:  Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0 - "Zero"
	273 - "Two hundred seventy three"
	400 - "Four hundred"
	501 - "Five hundred and one"
	711 - "Seven hundred and eleven" */
var hundreds = 0,
    tens = 0,
    teens = 0,
    ones = 0,
    input = prompt("Please enter a number in the range [0...999]"),
    finalMsg = '';

function getHundreds() {
    switch (hundreds) {
        case 1:
            finalMsg = finalMsg + "One hundred ";
            break;
        case 2:
            finalMsg = finalMsg + "Two hundred ";
            break;
        case 3:
            finalMsg = finalMsg + "Three hundred ";
            break;
        case 4:
            finalMsg = finalMsg + "Four hundred ";
            break;
        case 5:
            finalMsg = finalMsg + "Five hundred ";
            break;
        case 6:
            finalMsg = finalMsg + "Six hundred ";
            break;
        case 7:
            finalMsg = finalMsg + "Seven hundred ";
            break;
        case 8:
            finalMsg = finalMsg + "Eight hundred ";
            break;
        case 9:
            finalMsg = finalMsg + "Nine hundred ";
            break;
        default:
            break;
    }
}

function getTeens() {
    switch (teens) {
        case 10:
            finalMsg = finalMsg + "Ten";
            break;
        case 11:
            finalMsg = finalMsg + "Eleven";
            break;
        case 12:
            finalMsg = finalMsg + "Twelve";
            break;
        case 13:
            finalMsg = finalMsg + "Thirteen";
            break;
        case 14:
            finalMsg = finalMsg + "Forteen";
            break;
        case 15:
            finalMsg = finalMsg + "Fifteen";
            break;
        case 16:
            finalMsg = finalMsg + "Sixteen";
            break;
        case 17:
            finalMsg = finalMsg + "Seventeen";
            break;
        case 18:
            finalMsg = finalMsg + "Eighteen";
            break;
        case 19:
            finalMsg = finalMsg + "Nineteen";
            break;
        default:
            finalMsg = finalMsg + "No such number or out of range";
            break;
    }
}

function getTens() {

    switch (tens) {
        case 0:
            break;
        case 2:
            finalMsg = finalMsg + "Twenty ";
            break;
        case 3:
            finalMsg = finalMsg + "Thirty ";
            break;
        case 4:
            finalMsg = finalMsg + "Forty ";
            break;
        case 5:
            finalMsg = finalMsg + "Fifty ";
            break;
        case 6:
            finalMsg = finalMsg + "Sixty ";
            break;
        case 7:
            finalMsg = finalMsg + "Seventy ";
            break;
        case 8:
            finalMsg = finalMsg + "Eighty ";
            break;
        case 9:
            finalMsg = finalMsg + "Ninety ";
            break;
        default:
            finalMsg = finalMsg + "No such number or out of range";
            break;
    }
}

function getOnes() {

    switch (ones) {
        case 0:
            finalMsg = finalMsg + "Zero ";
            break;
        case 1:
            finalMsg = finalMsg + "One ";
            break;
        case 2:
            finalMsg = finalMsg + "Two ";
            break;
        case 3:
            finalMsg = finalMsg + "Three ";
            break;
        case 4:
            finalMsg = finalMsg + "Four ";
            break;
        case 5:
            finalMsg = finalMsg + "Five ";
            break;
        case 6:
            finalMsg = finalMsg + "Six ";
            break;
        case 7:
            finalMsg = finalMsg + "Seven ";
            break;
        case 8:
            finalMsg = finalMsg + "Eight ";
            break;
        case 9:
            finalMsg = finalMsg + "Nine ";
            break;
        default:
            break;
    }
}

if (!isNaN(input)) {
    if (input.length === 3) {
        if (input[0] != 0) {
            hundreds = parseInt(input[0]);
            getHundreds();
            if ((input[1] == 0 && input[2] > 0) || input[1] == 1) {
                finalMsg = finalMsg + "and "
            }
        }
        if (input[1] == 1) {
            teens = parseInt(input[1] + input[2]);
            getTeens();
        } else if (input[1] > 1 || input[1] == 0) {
            tens = parseInt(input[1]);
            getTens();

            if (input[2] > 0) {
                ones = parseInt(input[2]);
                getOnes();
            }

        }
    } else if (input.length === 2) {
        if (input[0] != 0) {
            if (input[0] == 1) {
                teens = parseInt(input[1] + input[2]);
                getTeens();
            } else if (input[0] > 1) {
                tens = parseInt(input[0]);
                getTens();
            }
        }
        if (input[1] > 0) {
            ones = parseInt(input[1]);
            getOnes();
        }
    } else {
        ones = parseInt(input[0]);
        getOnes();
    }

    alert(finalMsg);
} else {
    alert("You have not entered a valid number");
}
