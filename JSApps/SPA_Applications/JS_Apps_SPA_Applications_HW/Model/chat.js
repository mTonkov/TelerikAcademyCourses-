(function () {
    require.config({
        paths: {
            "hb": "../libs/handlebars",
            "jquery": "../libs/jquery-2.1.1.min",
            "template": "../Controller/createTemplate"
        }
    });

    var url = "http://crowd-chat.herokuapp.com/posts";

    require(["template", "hb", "jquery"], function (compiledTemplate, Handlebars, $) {
        $('#get-all-messages').on('click', function () {
            $.get(url)
            .then(function (data) {
                console.log(data);
                var readyHTML = compiledTemplate({ posts: data });
                $("#all-chat-messages").html(readyHTML);
            }, function error(err) {
                console.log(err);
            });
        });

        $('#send-message').on('click', function () {
            var user = $('#username').val(),
                msg = $("#message").val();

            $.post(url, {
                user: user,
                text: msg
            })
            .then(function (data) {
                console.log(data);

                if (data === true) {
                    $("#all-chat-messages").html(user+"'s message was added successfully!");
                }
            }, function error(err) {
                console.log(err);
            });
        });

    })
})()