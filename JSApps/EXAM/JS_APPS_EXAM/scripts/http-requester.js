define(['jquery'], function ($) {

    var httpRequester = (function () {
        function getJSON(url) {
            var getJsonPromise = $.Deferred();

            $.ajax({
                url: url,
                type: "GET",
                timeout: 5000,
                contentType: "application/json",
                success: function (successData) {
                    getJsonPromise.resolve(successData);
                },
                error: function (errorData) {
                    getJsonPromise.reject(errorData);
                }
            });

            return getJsonPromise.promise();
        }
        function postJSON(url, data, sessionKey) {
            var postJsonPromise = $.Deferred();

            $.ajax({
                url: url,
                type: "POST",
                contentType: "application/json",
                "X-SessionKey": sessionKey,
                timeout: 5000,
                data: JSON.stringify(data),
                success: function (successData) {
                    postJsonPromise.resolve(successData);
                },
                error: function (errorData) {
                    postJsonPromise.reject(errorData);
                }
            });

            return postJsonPromise.promise();
        }

        function put(url, sessionKey) {
            var putPromise = $.Deferred();

            $.ajax({
                url: url,
                type: "PUT",
                //contentType: "application/json",
                timeout: 5000,
                data: true,
                "X-SessionKey": sessionKey,
                success: function (successData) {
                    putPromise.resolve(successData);
                },
                error: function (errorData) {
                    putPromise.reject(errorData);
                }
            });

            return putPromise.promise();
        }

        return {
            getJSON: getJSON,
            postJSON: postJSON,
            put: put
        };
    }());

    return httpRequester;
})