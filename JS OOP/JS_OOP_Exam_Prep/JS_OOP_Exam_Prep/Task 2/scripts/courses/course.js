define(function () {
    var Course;
    Course = (function () {
        function Course(title, calculationFormula) {
            this.title = title;
            this._calcTotalScore = calculationFormula;
            this._students = [];
        }

        Course.prototype = {
            addStudent: function (student) {
                this._students.push(student);
            },
            calculateResults: function () {
                for (var i = 0, length = this._students.length; i < length; i++) {
                    var student = this._students[i];

                    student.totalScore = this._calcTotalScore(student);
                }
            },
            getTopStudentsByExam: function (count) {
                return sortStudents(this._students, "exam").slice(0, count)
            },
            getTopStudentsByTotalScore: function (count) {
                return sortStudents(this._students, "totalScore").slice(0, count)
            }
        }

        function sortStudents(collection, sortBy) {
            return collection.sort(function (first, second) {
                return second[sortBy] - first[sortBy];
            });
        }

        return Course;
    }());

    return Course;
})