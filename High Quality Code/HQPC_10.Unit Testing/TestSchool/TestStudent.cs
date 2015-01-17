namespace TestSchool
{
    using HQPC_School;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class TestStudent
    {
        [TestMethod]
        public void TestStudentInitializationNameAssignment()
        {
            string studentName = "Ivan Ivanov";
            int studentID = 12345;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentName, newStudent.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentSmallerThanExpectedInvalidNameAssignment()
        {
            string studentName = "Ivan";
            int studentID = 12345;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentName, newStudent.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentEmptyNameAssignment()
        {
            string studentName = "";
            int studentID = 12345;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentName, newStudent.Name);
        }

        [TestMethod]
        public void TestStudentInitializationIDAssignment()
        {
            string studentName = "Ivan Ivanov";
            int studentID = 12345;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentID, newStudent.IDNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIDBiggerThanTheGivenRange()
        {
            string studentName = "Ivan Ivanov";
            int studentID = 123456789;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentID, newStudent.IDNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestIDSmallerThanTheGivenRange()
        {
            string studentName = "Ivan Ivanov";
            int studentID = 1234;

            Student newStudent = new Student(studentName, studentID);
            Assert.AreEqual(studentID, newStudent.IDNumber);
        }
    }
}
