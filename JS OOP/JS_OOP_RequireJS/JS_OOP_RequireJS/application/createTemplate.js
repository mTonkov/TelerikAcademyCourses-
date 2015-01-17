define(["hb"], function () {
    var templateHolder = document.getElementById("handlebars-template"),
        template = templateHolder.innerHTML,
        compiledTemplate = Handlebars.compile(template);

    return compiledTemplate;
})