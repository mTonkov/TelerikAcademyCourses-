(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "students": "../students-data"
        }
    });

    require(["underscore", "students"], function (_, students) {
        var sortedStudents =
            _.chain(students)
            .filter(function (student) {
                return 18 <= student.age && student.age <= 24;
            })
            .each(function (student) {
                console.log(student.fullname);
            });
    });
}())