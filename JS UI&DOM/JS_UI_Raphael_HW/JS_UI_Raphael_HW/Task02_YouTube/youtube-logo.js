/// <reference path="raphael-min.js" />

var raphaelSvg = Raphael(0, 0, 1200, 600);

raphaelSvg.text(100, 100, "You")
.attr({
    "font-family": "TradeGothicW01-BoldCn20 675334",
    "font-size": "72",
    fill: "#555",
    "font-weight": 700
});

raphaelSvg.rect(180, 50, 200, 100, 30)
    .attr({
        stroke: "#fa0000",
        fill: "#fa0000",
    });

raphaelSvg.text(280, 100, "Tube")
.attr({
    "font-family": "TradeGothicW01-BoldCn20 675334",
    "font-size": "72",
    fill: "#fff",
    "font-weight": 700
});

