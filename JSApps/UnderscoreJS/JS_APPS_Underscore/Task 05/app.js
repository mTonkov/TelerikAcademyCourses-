(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "animals": "../animals-data"
        }
    });

    require(["underscore", "animals"], function (_, animals) {
        var totalLegsCount = 0;

        _.each(animals, function (animal) {
            totalLegsCount += animal.legsCount;
        });

        console.log(totalLegsCount);
    });
}())