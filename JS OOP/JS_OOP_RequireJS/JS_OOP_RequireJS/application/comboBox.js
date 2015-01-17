define(["animals", "createTemplate", "hb"], function (data, template) {
    var htmlFromTemplate = template(data);
    document.body.innerHTML += htmlFromTemplate;
})