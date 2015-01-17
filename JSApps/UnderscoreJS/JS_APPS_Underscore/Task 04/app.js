(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "animals": "../animals-data"
        }
    });

    require(["underscore", "animals"], function (_, animals) {
        var groupedSortedAnimals = _.chain(animals)
        .sortBy("legsCount")
        .groupBy("species")
        .value();

        console.log(groupedSortedAnimals);
    });
}())