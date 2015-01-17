define(function () {
    var Book = (function () {

        function Book(author, bookName) {
            this.author = author;
            this.name = bookName;
        }

        return Book;
    }());


    var books = [
        new Book("Dan Brown", "The Da Vinci Code"),
        new Book("J. K. Rowling", "Harry Potter and the Philosopher's Stone"),
        new Book("Stephen King", "The Green Mile"),
        new Book("Dan Brown", "Angels & Demons"),
        new Book("J. R. R. Tolkien", "The Lord Of The Rings"),
        new Book("J. K. Rowling", "Harry Potter and the Prisoner of Azkaban"),
        new Book("Dan Brown", "The Lost Symbol"),
        new Book("J. R. R. Tolkien", "The Hobbit"),
        new Book("Dan Brown", "Inferno"),
        new Book("George R.R. Martin", "A Game of Thrones"),
        new Book("Stephen King", "It"),
        new Book("J. K. Rowling", "Harry Potter and the Order of the Phoenix")
    ];

    return books;
})