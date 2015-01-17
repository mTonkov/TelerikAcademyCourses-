namespace TestSchool
{
    using HQPC_School;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class TestCourse
    {
        [TestMethod]
        public void TestEmptyCourseNumberOfStudents()
        {
            Course course = new Course();
            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        public void TestNewCourseConstructionWithStudentsParameter()
        {
            var ivan = new Student("Ivan Ivanov", 12345);
            var gosho = new Student("Gosho Petrov", 22345);
            var pesho = new Student("Pesho Ivanov", 32345);

            List<Student> courseStudents = new List<Student>();
            courseStudents.Add(ivan);
            courseStudents.Add(gosho);
            courseStudents.Add(pesho);

            Course myNewCourse = new Course(courseStudents);

            Assert.AreEqual(3, myNewCourse.Students.Count);
        }


        [TestMethod]
        public void TestAssignStudentsToCourse()
        {
            Course course = new Course();
            var newStudents = new List<Student>(5);
            course.Students = newStudents;
            Assert.AreEqual(newStudents.Count, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAssignMoreStudentsThanAllowedToCourse()
        {
            Course course = new Course();
            var newStudents = new List<Student>();
            for (int i = 0; i < 35; i++)
            {
                var newStudent = new Student("Student " + i, 10000 + i);
                newStudents.Add(newStudent);
            }
            course.Students = newStudents;
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestAssignNullStudentsToCourse()
        {
            Course course = new Course();
            List<Student> newStudents = null;

            course.Students = newStudents;
        }

        [TestMethod]
        public void TestAddStudentsToCourse()
        {
            Course course = new Course();
            int numberOfStudents = 30;

            for (int i = 0; i < numberOfStudents; i++)
            {
                var newStudent = new Student("Student " + i, 10000 + i);
                course.AddStudent(newStudent);
            }
            Assert.AreEqual(numberOfStudents, course.Students.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestAddMoreThanMaximumStudentsToCourse()
        {
            Course course = new Course();
            int numberOfStudents = 30;

            for (int i = 0; i < numberOfStudents; i++)
            {
                var newStudent = new Student("Student " + i, 10000 + i);
                course.AddStudent(newStudent);
            }

            course.AddStudent(new Student("Ivan Ivanov", 23456));
        }

        [TestMethod]
        public void TestRemoveAddedStudentsFromCourse()
        {
            Course course = new Course();

            var ivan = new Student("Ivan Ivanov", 12345);
            var gosho = new Student("Gosho Petrov", 22345);
            var pesho = new Student("Pesho Ivanov", 32345);

            course.AddStudent(ivan);
            course.AddStudent(gosho);
            course.AddStudent(pesho);

            Assert.AreEqual(3, course.Students.Count);

            course.RemoveStudent(ivan);
            course.RemoveStudent(gosho);

            Assert.AreEqual(1, course.Students.Count);
        }

        [TestMethod]
        public void TestProtectionOfPrivateStudentsDataInThePropertyGetter()
        {
            var myCourse = new Course();
            var someStudents = myCourse.Students;

            Assert.AreEqual(0, someStudents.Count);

            myCourse.AddStudent(new Student("Ivan Ivanov", 45678));
            Assert.AreEqual(1, myCourse.Students.Count);
        }
    }
}
