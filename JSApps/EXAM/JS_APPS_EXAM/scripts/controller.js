define(['persister', 'jquery', 'ui', 'class', 'underscore', 'hb'], function (persisters, $, ui, Class, _, Handlebars) {
    var controllers = (function () {

        var updateTimer = null;

        var rootUrl = "http://localhost:3000/";
        var Controller = Class.create({
            init: function () {
                this.persister = persisters.get(rootUrl);
            },
            loadUI: function (selector) {
                if (this.persister.isUserLoggedIn()) {
                    this.loadLoggedInUser(selector);
                }
                else {
                    this.loadNOTLoggedUser(selector);
                }
                this.attachUIEventHandlers(selector);
            },
            loadLoggedInUser: function (selector) {
                $(selector).html(ui.initial);
                $(selector + " #additional-user-actions").html(ui.sendMsgForm);
            },
            loadNOTLoggedUser: function (selector) {
                $(selector).html(ui.initial);
            },
            attachUIEventHandlers: function (selector) {
                var wrapper = $(selector);
                var self = this;

                wrapper.on("click", "#btn-login", function () {
                    var user = {
                        username: $(selector + " #tb-username").val(),
                        password: $(selector + " #tb-password").val()
                    }

                    self.persister.user.login(user, function () {
                        this.loadLoggedInUser(selector);
                    }, function (err) {
                        alert(err.Message);
                    });
                    return false;
                });

                wrapper.on("click", "#btn-register", function () {
                    var user = {
                        username: $(selector + " #tb-username").val(),
                        password: $(selector + " #tb-password").val()
                    }
                    self.persister.user.register(user, function () {
                        this.loadLoggedInUser(selector);
                    }, function (err) {
                        alert(err.Message);
                    });
                    return false;
                });

                wrapper.on("click", "#btn-logout", function () {
                    self.persister.user.logout(function () {
                        this.loadNOTLoggedUser(selector);
                    }, function (err) {
                        alert(err.Message);
                    });
                });

                wrapper.on("click", "#btn-send-message", function () {
                    var msgTitle = $(selector + ' #user-message-title').val();
                    var msgBody = $(selector + ' #user-message-body').val();

                    var finalMsg = {
                        title: msgTitle,
                        body: msgBody
                    };
                    self.persister.message.send(finalMsg, function () {
                        alert("Your message was sent successfully!");
                    }, function (err) {
                        alert(err.Message);
                    })
                });
                wrapper.on("click", "#btn-get-messages", function () {
                    var userFilter = $(selector + " #filter-by-user").val();
                    var patternFilter = $(selector + " #filter-by-pattern").val();

                    var sortBy = $("sortby-select").val();
                    var isDescending = $("is-descending").prop('checked');
                    self.persister.message.getAll(userFilter, patternFilter, function success(data) {
                        var sortedData = _.sortBy(data, sortBy);
                        if (isDescending) {
                            // not enough time
                        }
                        var postTemplateNode = document.getElementById('messages-template'),
    postTemplateHtml = templateNode.innerHTML,
    postTemplate = Handlebars.compile(postTemplateHtml);
                        $('#returned-messages').html(postTemplate(sortedData));
                    }, function error(err) {
                        alert(err.Message);
                    })

                });
            }
        });
        return {
            get: function () {
                return new Controller();
            }
        }
    }());

    return controllers;
})

//$(function () {
//	var controller = controllers.get();
//	controller.loadUI("#content");
//});