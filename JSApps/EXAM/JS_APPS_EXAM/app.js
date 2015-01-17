(function () {
    require.config({
        paths: {
            "hb": "libs/handlebars-v1.3.0",
            "jquery": "libs/jquery-2.1.1.min",
            "underscore": "libs/underscore-min",
            "class": "libs/class",
            "sammy": "libs/sammy-latest.min",
            "controller": "scripts/controller",
            "httpRequester": "scripts/http-requester",
            "persister": "scripts/persister",
            "ui": "scripts/ui",
            "CryptoJS": "http://crypto-js.googlecode.com/svn/tags/3.1.2/build/rollups/sha1.js"
        }
    });

    require(["controller", "jquery"], function (controller, $) {
        $(function () {
            var controller = controllers.get();
            controller.loadUI("#content");
        });
    })
})()