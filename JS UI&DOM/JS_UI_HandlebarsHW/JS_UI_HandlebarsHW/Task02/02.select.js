/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_HandlebarsHW\JS_UI_HandlebarsHW\handlebars-v1.3.0.js" />
var htmlTemplateHolder = document.getElementById("template-container"),
    htmlTemplate = htmlTemplateHolder.innerHTML,
    htmlCompiler = Handlebars.compile(htmlTemplate);

var items = [{
    value: 1,
    text: 'One'
}, {
    value: 2,
    text: 'Two'
}, {
    value: 3,
    text: 'Three'
}, {
    value: 4,
    text: 'Four'
}, {
    value: 5,
    text: 'Five'
}];

document.body.innerHTML = htmlCompiler({ collection: items });