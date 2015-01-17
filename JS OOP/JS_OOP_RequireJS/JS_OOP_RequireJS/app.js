/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_OOP_RequireJS\JS_OOP_RequireJS\libraries/jquery-2.1.1.min.js" />
(function () {
    require.config({
        paths: {
            "hb": "libs/handlebars-v1.3.0",
            "animals": "data/animals",
            "jquery": "libs/jquery-2.1.1.min",
            "createTemplate": "application/createTemplate"
        }
    });

    require(["jquery", "application/comboBox"], function ($) {

        var $dropdownList = $("#wrapper");
        $(".combo-box-item").first().addClass("current");

        function collapseDropdown() {
            var contentOnTop = $(".current").html();

            $("#current-selected")
                .html(contentOnTop)
                .css({
                    "-moz-user-select": "none",
                    "-webkit-user-select": "none",
                    "-ms-user-select": "none",
                    "user-select": "none"
                });
            $(".combo-box-item").css("display", "none");
        }
        collapseDropdown();

        //events
        var clickCounter = 0;
        $("#current-selected").on("click", function () {
            clickCounter++;
            $(".combo-box-item").css("display", "");

            if (clickCounter == 2) {
                clickCounter = 0;
                collapseDropdown();
            }
        });

        $dropdownList.on("click", ".combo-box-item", function () {
            var $this = $(this);

            $(".current").removeClass("current");
            $this.addClass("current");
            clickCounter = 0;
            collapseDropdown();
        });
    });
}());
