/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Overview_HW\JS_UI_jQuery_Overview_HW\jquery-2.1.1.min.js" />


$("<input />")
    .attr("type", "color")
    .attr("id", "color-input")
    .appendTo('body');

$("#color-input").on("change", setBackgroundColor);

function setBackgroundColor() {
    var color = $("#color-input").val();

    $("body").css("background-color", color);
}