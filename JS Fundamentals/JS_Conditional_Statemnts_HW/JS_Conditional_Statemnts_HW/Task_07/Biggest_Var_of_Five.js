/* task: Write a script that finds the greatest of given 5 variables.*/


var biggest = '',
    a = [];
for (var i = 0; i < 5; i++) {
    a[i] = prompt("Please enter variable number " + (i+1), 0);
    if (!isNaN(a[i])) {
        a[i] = parseInt(a[i]);
    }
    if (a[i] > biggest) {
        biggest = a[i];
    }
}

alert("The greatest input of all five is " + biggest);
