/// <reference path="raphael-min.js" />

var raphaelSvg = Raphael(0, 0, 1200, 600);

raphaelSvg.path("M50 100 L100 50 L200 150 L150 200 L100 150 L200 50 L250 100")
.attr({
    stroke: "#7CFC00",
    "stroke-width":"15",
});

raphaelSvg.text(600, 130, "Telerik ")
.attr({
    "font-size": "170",
    "font-weight": 700
});

raphaelSvg.text(900, 120, "\u00AE")
    .attr({
        "font-size": "50"
    });

raphaelSvg.text(690, 250, "Develop experiences")
.attr({
    "font-size": "70",
});
