define(["hb", "jquery"], function () {
    var template = $("#template").html(),
    waitingDataTemplate = Handlebars.compile(template);

    return waitingDataTemplate;
})