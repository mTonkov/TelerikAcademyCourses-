(function () {
    require.config({
        paths: {
            "jquery": "../libs/jquery-2.1.1.min",
            "oauth": "../libs/oauth",
        }
    })

    require(["jquery", "oauth"], function ($) {

        function getAuthorizationPromise() {
            OAuth.initialize('PbLXph5pZdSVKiOphQioH1MnH_k');
            var authPromise = OAuth.popup('twitter', {
                cache: true
            });

            return authPromise;
        }

        $('#authorize').on('click', function () {
            getAuthorizationPromise()
            .done(function () {
                console.log('Authenticated succesfully. Your login authorization has been cached.');
            })
            .fail(function (err) {
                console.log(err);
            });
        })

        $('#get-user').on('click', function () {
            var username = $('#username').val(),
                messageCount = parseInt($('#count').val());
            requestUrl = 'https://api.twitter.com/1.1/statuses/user_timeline.json?count=' + messageCount + '&screen_name=' + username;
            getAuthorizationPromise()
            .done(function (result) {
                result.get(requestUrl)
                .done(function (response) {
                    console.log(response);
                    var $ul = $("<ul/>").addClass('all-posts');

                    for (var i = 0; i < response.length; i++) {
                        var post = response[i];
                        var $image = $('<img/>').addClass("avatar").attr("src", post.user.profile_image_url);
                        $('<li/>')
                            .addClass("single-post")
                            .append($image)
                            .append($('<span/>').addClass('user-name').html(post.user.name + ':'))
                            .append($('<p/>').addClass('user-post').html(post.text))
                            .appendTo($ul);
                    }
                    $('#result').html($ul);
                })
                .fail(function (error) {
                    console.log(error);
                });
            })
        });
    })
})()