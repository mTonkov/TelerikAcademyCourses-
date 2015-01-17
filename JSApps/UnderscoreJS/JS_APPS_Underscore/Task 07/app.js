(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "students": "../students-data"
        }
    });

    require(["underscore", "students"], function (_, students) {
        var firstName = _.chain(students)
            .countBy('fname')
            .pairs()
            .max(function (pair) {
                return pair[1];
            })
            .value();

        var lastName = _.chain(students)
            .countBy('lname')
            .pairs()
            .max(function (pair) {
                return pair[1];
            })
            .value();

        console.log("The most frequent first name is '" + firstName[0]+"'");
        console.log("and the most frequent last name is '"+ lastName[0]+"'");
    });
}())