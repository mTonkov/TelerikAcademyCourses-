/// <reference path="raphael-min.js" />

var raphaelSVG = Raphael(0, 0, 900, 600),
    spiralStartX = 450,
    spiralStartY = 300,
    a = 0,
    b = 2;


for (var i = 0; i < 500; i++) {
    var angle = 0.1 * i,
        x = spiralStartX + (a + b * angle) * Math.cos(angle),
        y = spiralStartY + (a + b * angle) * Math.sin(angle);

    raphaelSVG.circle(x, y, 1);
}
