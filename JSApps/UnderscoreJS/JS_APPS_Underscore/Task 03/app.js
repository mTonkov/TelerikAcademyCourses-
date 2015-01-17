(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "students": "../students-data"
        }
    });

    require(["underscore", "students"], function (_, students) {
        var studentWithHighestMark = _.chain(students)
        .sortBy("mark")
        .last()
        .value();

        console.log(studentWithHighestMark);
    });
}())