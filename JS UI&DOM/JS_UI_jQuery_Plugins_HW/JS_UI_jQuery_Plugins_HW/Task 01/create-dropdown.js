/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Plugins_HW\JS_UI_jQuery_Plugins_HW\jquery-2.1.1.min.js" />
(function ($) {
    $.fn.dropdown = function () {
        var $this = $(this);
        var $dropdownContainer = $("<div />").addClass("dropdown-list-container");
        var $dropdownList = $("<ul />").addClass("dropdown-list-options");
        var $options = $this.find("option");

        for (var i = 0; i < $options.length; i++) {//create <li> elements and set attributes
            var $optionLi = $("<li />")
                .attr({
                    "data-value": $options[i].value,
                    "class": "dropdown-list-option"
                })
                .text($options[i].innerText)
                .css("list-style-type", "none");

            $dropdownList.append($optionLi);
        }

        $dropdownContainer.append($dropdownList);//append all to DOM
        $this.css("display", "none").after($dropdownContainer);

        $(".dropdown-list-option").first().addClass("current");
        $("<div />")
            .attr("id", "current-selected")
            .prependTo($dropdownContainer);

        function collapseDropdown() {
            var textOnTop = $(".current").text();
            $("#current-selected")
                .text(textOnTop)
                .css({
                    "-moz-user-select": "none",
                    "-webkit-user-select": "none",
                    "-ms-user-select": "none",
                    "user-select": "none"
                });
            $(".dropdown-list-options").css("display", "none");
        }
        collapseDropdown();

        //events
        var clickCounter = 0;
        $("#current-selected").on("click", function () {
            clickCounter++;
            $(".dropdown-list-options").css("display", "");

            if (clickCounter == 2) {
                clickCounter = 0;
                collapseDropdown();
            }
        });

        $dropdownList.on("click", ".dropdown-list-option", function () {
            var $this = $(this);

            $(".current").removeClass("current");
            $this.addClass("current");
            clickCounter = 0;
            collapseDropdown();
        });
    }
}(jQuery));

$("#dropdown").dropdown();