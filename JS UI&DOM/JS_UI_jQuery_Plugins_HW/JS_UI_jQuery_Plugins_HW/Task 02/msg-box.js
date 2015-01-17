/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Plugins_HW\JS_UI_jQuery_Plugins_HW\jquery-2.1.1.min.js" />
(function ($) {
    $.fn.messageBox = function () {
        var $this = $(this);

        function throwMessage(message, color) {
            $this.text(message).css("color", color);

            $this.fadeIn(1000, function () {
                $this.fadeOut(3000);
            });
        }

        return {
            success: function (message) {
                throwMessage(message, "yellowgreen");
            },
            error: function (message) {
                throwMessage(message, "magenta");
            }
        }
    }
}(jQuery));

var msgBox = $("#message-box").messageBox();

msgBox.success("Congrats...You did it!");
//msgBox.error("Sorry, there is an error!");
