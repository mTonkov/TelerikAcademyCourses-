(function () {
    require.config({
        paths: {
            "underscore": "../libs/underscore-min",
            "books": "../books-data"
        }
    });

    require(["underscore", "books"], function (_, books) {
        var sortedBooks = _.chain(books)
            .countBy("author")
            .pairs()
            .max(function (pair) {
                return pair[1];
            })
            .value();

        console.log(sortedBooks);
        console.log(sortedBooks[0] + " has the most books: " + sortedBooks[1]);

    });
}())