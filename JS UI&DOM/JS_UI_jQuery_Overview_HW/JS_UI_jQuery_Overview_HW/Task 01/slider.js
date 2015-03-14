/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Overview_HW\JS_UI_jQuery_Overview_HW\jquery-2.1.1.min.js" />
var images = ["Desert.jpg", "Lighthouse.jpg", "Tulips.jpg"];
var $existingSlides = $("#wrapper").children('.slide');
var $traversionHolder = $('<div />');

$($existingSlides[0]).addClass("current");
for (var i = 0, length = $existingSlides.length; i < length; i++) {
    $traversionHolder.append($existingSlides[i]);

    $('<img />')
        .addClass("slide")
        .attr('src', images[i % images.length])
        .appendTo($traversionHolder);
}

$("<button />")
    .addClass("button")
    .attr("id", "btn-prev")
    .html("< Prev")
    .appendTo("body");

$("<button />")
    .addClass("button")
    .attr("id", "btn-next")
    .html("Next >")
    .appendTo("body");

var newHtml = $traversionHolder.html();
$('#wrapper').html(newHtml);

//button events
$("#btn-prev").on("click", onPrevButtonClick);
$("#btn-next").on("click", getNextElement);

function onPrevButtonClick() {
    $('.current').removeClass("current").prevOrLast().addClass("current");
}

function getNextElement() {
    $('.current').removeClass("current").nextOrFirst().addClass("current");
}
setInterval(getNextElement, 5000);

jQuery.fn.nextOrFirst = function(selector){//if the current element is the last one, the first is selected
    
    var next = this.next(selector);
	
    return (next.length) ? next : this.prevAll(selector).last();
}

jQuery.fn.prevOrLast = function(selector){
    var prev = this.prev(selector);
	console.log(prev);
    return (prev.length) ? prev : this.nextAll(selector).last();
}