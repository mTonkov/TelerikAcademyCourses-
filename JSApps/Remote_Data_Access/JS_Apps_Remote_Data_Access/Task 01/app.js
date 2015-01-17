(function () {
    require.config({
        paths: {
            "jquery": "../libs/jquery-2.1.1.min",
            "exposed-methods": "expose_methods"
        }
    })

    require(["jquery", "exposed-methods"], function ($, request) {
        setTimeout(function () {
            request.getJSON("users.js")
            .then(
            function successCase(data) {
                console.log(data.length);
                var $list = $('<ul/>').addClass("presented-data");
                for (var i = 0; i < data.length; i++) {
                    var $li = $("<li/>")
                        .addClass("list-item")
                        .html("User " + (i + 1) + ": is " + data[i].fname + " " + data[i].lname)
                        .appendTo($list);
                }
                $list.appendTo('body');
            },
            function errorCase(error) {
                $("<h4/>")
                .html(error.responseText)
                .appendTo('body');
            })
        }, 1500);
    })
})()