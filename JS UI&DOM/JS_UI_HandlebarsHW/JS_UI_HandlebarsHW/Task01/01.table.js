/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_HandlebarsHW\JS_UI_HandlebarsHW\handlebars-v1.3.0.js" />
var htmlTemplateHolder = document.getElementById("template-container"),
    htmlTemplate = htmlTemplateHolder.innerHTML,
    htmlCompiler = Handlebars.compile(htmlTemplate);

var lectionsHighQualityCode = [
    {
        id: 15,
        title: "Development Tools",
        firstDate: "25-06-2014 14:00:00",
        secondDate: "27-06-2014 18:00:00",
    },
    {
        id: 16,
        title: "SOLID Principles + DRY",
        firstDate: "02-07-2014 14:00:00",
        secondDate: "04-07-2014 18:00:00",
    },
    {
        id: 17,
        title: "Design Patterns - Part 1",
        firstDate: "09-07-2014 14:00:00",
        secondDate: "11-07-2014 18:00:00",
    },
    {
        id: 18,
        title: "Design Patterns - Part 2",
        firstDate: "16-07-2014 14:00:00",
        secondDate: "18-07-2014 18:00:00",
    },
    {
        id: 19,
        title: "Software Engineering Fundamentals",
        firstDate: "23-07-2014 14:00:00",
        secondDate: "25-07-2014 18:00:00",
    },
        {
            id: 20,
            title: "Software Quality Assurance Mocking and JustMock",
            firstDate: "30-07-2014 14:00:00",
            secondDate: "01-08-2014 18:00:00",
        },
];

document.body.innerHTML = htmlCompiler({ collection: lectionsHighQualityCode });