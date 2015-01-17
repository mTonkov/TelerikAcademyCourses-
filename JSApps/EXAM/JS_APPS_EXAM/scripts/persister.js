define(['class', 'httpRequester', 'CryptoJS'], function (Class, httpRequester, CryptoJS) {


    var persisters = (function () {
        var nickname = localStorage.getItem("nickname");
        var sessionKey = localStorage.getItem("sessionKey");
        function saveUserData(userData) {
            localStorage.setItem("nickname", userData.username);
            localStorage.setItem("sessionKey", userData.authCode);
            nickname = userData.username;
            sessionKey = userData.authCode;
        }
        function clearUserData() {
            localStorage.removeItem("nickname");
            localStorage.removeItem("sessionKey");
            nickname = "";
            sessionKey = "";
        }

        var MainPersister = Class.create({
            init: function (rootUrl) {
                this.rootUrl = rootUrl;
                this.user = new UserPersister(this.rootUrl);
                this.message = new MessagesPersister(this.rootUrl);
            },
            isUserLoggedIn: function () {
                var isLoggedIn = nickname != null && sessionKey != null;
                return isLoggedIn;
            },
            nickname: function () {
                return nickname;
            }
        });
        var UserPersister = Class.create({
            init: function (rootUrl) {
                this.rootUrl = rootUrl;
            },
            login: function (user, success, error) {
                var url = this.rootUrl + "auth";
                var userData = {
                    username: user.username,
                    authCode: CryptoJS.SHA1(user.username + user.password).toString()
                };

                httpRequester.postJSON(url, userData)
                .then(function (data) {
                    saveUserData(data);
                    success(data);
                }, error);
            },
            register: function (user, success, error) {
                var url = this.rootUrl + "user";
                var userData = {
                    username: user.username,
                    authCode: CryptoJS.SHA1(user.username + user.password).toString()
                };
                httpRequester.postJSON(url, userData)
                .then(function (data) {
                    saveUserData(data);
                    success(data);
                }, error);
            },
            logout: function (success, error) {
                var url = this.rootUrl + "user/" + sessionKey;
                httpRequester.put(url, sessionKey)
                    .then(function (data) {
                        clearUserData();
                        success(data);
                    }, error);
            }
        });
        var MessagesPersister = Class.create({
            init: function (url) {
                this.rootUrl = url + "post";
            },
            send: function (data, success, error) {
                httpRequester.postJSON(this.rootUrl, data, sessionKey)
                .then(success, error);
            },
            getAll: function (user, pattern, success, error) {
                var url = this.rootUrl;
                if (pattern) {
                    url += "?pattern=" + pattern.toLowerCase();
                    if (user) {
                        url += "&";
                    }
                }
                if (user) {
                    url += "user=" + user.toLowerCase();
                }
                httpRequester.getJSON(url)
                    .then(success,
                    error);
            }
        });

        return {
            get: function (url) {
                return new MainPersister(url);
            }
        };
    }());

})