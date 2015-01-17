(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "students": "../students-data"
        }
    });

    require(["underscore", "students"], function (_, students) {
        var sortedStudents = _.chain(students)
            .filter(function (student) {
                return student.fname.toLowerCase() < student.lname.toLowerCase();
            })
            .sortBy('fullname')
            .reverse()
            .value();

        console.log(sortedStudents);
    });
}())