define(function () {
    var Student;
    Student = (function () {
        function Student(objInfo) {
            this.name = objInfo.name;
            this.exam = objInfo.exam;
            this.homework = objInfo.homework;
            this.attendance = objInfo.attendance;
            this.teamwork = objInfo.teamwork;
            this.bonus = objInfo.bonus;
        }
        
        return Student;
    }())

    return Student;
})