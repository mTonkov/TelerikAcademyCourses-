/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_UI_jQuery_Overview_HW\JS_UI_jQuery_Overview_HW\jquery-2.1.1.min.js" />

var students = [
    {
        firstName: "Ivan",
        lastName: "Ivanov",
        grade: "4"
    },
    {
        firstName: "Pesho",
        lastName: "Iordanov",
        grade: "5"
    },
    {
        firstName: "Maria",
        lastName: "Petrova",
        grade: "6"
    },
    {
        firstName: "Gergana",
        lastName: "Ivanova",
        grade: "4"
    },
    {
        firstName: "Gosho",
        lastName: "Petrov",
        grade: "3"
    },
];
var tableTitle = ["First name", "Last name", "Grade"];
var tr = $("<tr />");

$("<table />")
    .attr("id", "table")
    .appendTo('#wrapper');
$("#table")
    .append($("<thead />"));
$("thead")
    .append(tr);

for (var i = 0; i < tableTitle.length; i++) {
    var th = $("<th />").text(tableTitle[i]);

    $("thead tr")
    .append(th);
}

for (var i = 0; i < students.length; i++) {
    var tr = $("<tr />");
    for (var prop in students[i]) {
        var td = $("<td />").text(students[i][prop]);
        tr.append(td);
    }
    $("#table").append(tr);
}

$("table, tr,td,th").css({ "border": "1px solid black", "border-collapse": "collapse", "padding":"5px"});