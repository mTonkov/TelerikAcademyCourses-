/// <reference path="jquery.min.js" />
$.fn.tabs = function () {
    var $thisContainer = $(this);
    $thisContainer.addClass("tabs-container");

    $(".tabs-container .tab-item").first().addClass("current");

    $(".tabs-container .tab-item").on("click", function () {
        var $this = $(this);

        $(".current .tab-item-content").hide();
        $(".current").removeClass("current");
        $this.addClass("current");
        $(".current .tab-item-content").show();
    });
    $(".tab-item-content").hide();
    $(".current .tab-item-content").show();
};