/// <reference path="C:\Users\M.Tonkov\Documents\Visual Studio 2013\Projects\JS_Apps_Remote_Data_Access\JS_Apps_Remote_Data_Access\libs/jquery-2.1.1.min.js" />
(function () {
    require.config({
        paths: {
            "jquery": "../libs/jquery-2.1.1.min"
        }
    })

    require(["jquery"], function ($) {
        var url = 'http://localhost:3000/students';
        $('<div/>').addClass('list-container').appendTo('body');
        function getStudents() {
            $.get(url)
            .then(function (data) {
                var $table = $('<table/>')
                    .addClass("students-list")
                    .append($('<tr/>')
                            .append($('<th/>').html("ID"))
                            .append($('<th/>').html("NAME"))
                            .append($('<th/>').html("GRADE"))),
                    students = data.students;

                for (var i = 0; i < students.length; i++) {
                    var $row = $('<tr/>')
                        .append($('<td/>').html(students[i].id))
                        .append($('<td/>').html(students[i].name))
                        .append($('<td/>').html(students[i].grade))
                        .appendTo($table);
                }
                $('.list-container').html($table);
            },
            function (err) {
                console.log(err);
            })
        }

        $("#get-all").on('click', getStudents);

        $("#add-student").on('click', function () {
            var name = $('#input-name').val(),
                grade = $('#input-grade').val(),
                student = {
                    name: name,
                    grade: grade
                };

            $.post(url, student)
            .then(function (data) {
                console.log(data);
                getStudents();
            } ,
            function (err) {
                console.log(err);
            })
        });

        $("#delete-student").on('click', function () {
            var id = parseInt($('#input-id').val()),
                isSure = confirm("Are you sure you want to delete the student with ID " + id);

            if (isSure) {
                $.ajax({
                    url: url+"/"+id,
                    type: "POST",
                    data: {
                        _method: 'delete'
                    },
                    success: getStudents,
                    error: function (err) {
                        console.log(err);
                    }
                });
            }
        });
    })
})()