/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_Animations_HW\JS_UI_Animations_HW\external-libraries/raphael-min.js" />
var width = 1000,
    height = 600;

var svgField = Raphael(0, 0, width, height);

svgField.rect(0, 0, width, height)
.attr({
    stroke: "black",
    "stroke-width": 1
});

svgField.image(src = "../imgs/mario-background-cc.jpeg", 0, 0, width, height);
