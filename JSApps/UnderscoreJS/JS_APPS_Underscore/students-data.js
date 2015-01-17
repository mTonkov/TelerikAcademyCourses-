define(function () {

    var Student = (function () {
        function Student(fname, lname, age, mark) {
            this.fname = fname;
            this.lname = lname;
            this.age = age;
            this.mark = mark;
            this.fullname = this.fname + " " + this.lname;
        }

        Student.prototype.toString = function () {
            return this.fname + " " + this.lname + " " + this.age;
        }

        return Student;
    }());

    var students = [new Student("Pesho", "Ivanov", 15, 3),
                    new Student("Gosho", "Petrov", 27, 4),
                    new Student("Silviya", "Dobreva", 20, 5.5),
                    new Student("Joro", "Dimitrov", 19, 4.5),
                    new Student("Pesho", "Angelov", 16, 3.5),
                    new Student("Pesho", "Stoyanov", 24, 6),
                    new Student("Boris", "Ivanov", 16, 5.75),
                    new Student("Daniela", "Nikolova", 18, 5)];

    return students;
})