define(["jquery"], function ($) {
    function getJSON(url) {
        var getJsonPromise = $.Deferred();

        var ajaxSettings = {
            url: url,
            type: 'GET',
            contentType: "application/json",
            dataType: "json"
        };

        ajaxSettings.success = function (successData) {
            getJsonPromise.resolve(successData);
        }

        ajaxSettings.error = function (errorData) {
            getJsonPromise.reject(errorData);
        }

        $.ajax(ajaxSettings);
        console.log(getJsonPromise.promise());
        return getJsonPromise.promise();
    }

    function postJSON(url, data) {
        var postJsonPromise = $.Deferred();

        var ajaxSettings = {
            url: url,
            type: 'GET',
            data: data,
            contentType: "application/json",
            dataType: "json"
        };

        ajaxSettings.success = function (successData) {
            postJsonPromise.resolve(successData);
        }

        ajaxSettings.error = function (errorData) {
            postJsonPromise.reject(errorData);
        }

        $.ajax(ajaxSettings);

        return postJsonPromise.promise();
    }

    return {
        getJSON: getJSON,
        postJSON: postJSON
    };
})