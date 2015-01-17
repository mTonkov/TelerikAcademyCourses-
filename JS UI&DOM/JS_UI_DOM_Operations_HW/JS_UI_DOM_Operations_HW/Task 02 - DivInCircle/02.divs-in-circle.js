var divs = Array(5);

for (var i = 0; i < divs.length; i++) {
    var currDiv = document.createElement('div');
    currDiv.innerHTML = "DIV " + (i + 1);
    currDiv.style.position = "absolute";
    currDiv.style.width = "50px";
    currDiv.style.height = "50px";
    currDiv.style.border = "1px solid black";
    document.body.appendChild(currDiv);
    divs[i] = currDiv;
}


var trajectoryX = window.innerWidth / 2;
var trajectoryY = window.innerHeight / 2;
var radius = 100;

var angle = 0;

var functionTimer = setInterval(function moveDivs() {
    angle += 0.05;

    for (var i = 0; i < divs.length; i++) {
        var left = 0 | (trajectoryX + radius * Math.cos(i * 2 * Math.PI / divs.length + angle));
        var top = 0 | (trajectoryY + radius * Math.sin(i * 2 * Math.PI / divs.length + angle));
        divs[i].style.left = left + "px";
        divs[i].style.top = top + "px";
    }
}, 100);
