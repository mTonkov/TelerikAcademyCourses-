/// <reference path="c:\users\m.tonkov\documents\visual studio 2013\Projects\JS_Conditional_Statemnts_HW\JS_Conditional_Statemnts_HW\js-console.js" />
/* task: Write a script that enters the coefficients a, b and c of a quadratic equation
a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/


function equation() {
    var a = parseInt(document.getElementById("input-1").value),
        b = parseInt(document.getElementById("input-2").value),
        c = parseInt(document.getElementById("input-3").value),
        discriminant,
        x1,
        x2;

    discriminant = Math.sqrt(b * b - 4 * a * c);
    // finding the Discriminant is part of the rule for solving quadratic equations

    if (discriminant > 0) //A quadratic equation has two different roots if Discriminant > 0
    {
        x1 = ((-b) + discriminant) / (2 * a); // This is the formula to find the real roots
        x2 = ((-b) - discriminant) / (2 * a);

        jsConsole.writeLine("The real roots of the equation ax2+bx+c=0, are x1="+ x1+ " and x2="+ x2);
    }
    else if (discriminant == 0) //When Discriminant is equal to '0', there is only one real root -> x1=x2= -b / (2 * a)
    {
        x1 = -b / (2 * a);
        jsConsole.writeLine("Discriminant=0, so x1=x2= "+ x1);
    }
    else  // If Discriminant < 0, there are no roots
    {
        jsConsole.writeLine("The quadratic equation has no real roots!");
    }

}