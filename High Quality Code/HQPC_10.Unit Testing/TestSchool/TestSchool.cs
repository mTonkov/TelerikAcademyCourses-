namespace TestSchool
{
    using HQPC_School;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;

    [TestClass]
    public class TestSchool
    {
        [TestMethod]
        public void TestNumberOfCoursesOnEmptySchoolConstructor()
        {
            School mySchool = new School();

            Assert.AreEqual(0, mySchool.Courses.Count);
        }

        [TestMethod]
        public void TestNewCourseSchoolWithCoursesParameter()
        {
            var firstCourse = new Course();
            var secondCourse = new Course();
            var thirdCourse = new Course();

            List<Course> schoolCourses = new List<Course>();
            schoolCourses.Add(firstCourse);
            schoolCourses.Add(secondCourse);
            schoolCourses.Add(thirdCourse);

            School myNewSchool = new School(schoolCourses);

            Assert.AreEqual(3, myNewSchool.Courses.Count);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestAssigningTheCoursesANotAssignedListOfCourses()
        {
            School mySchool = new School();
            List<Course> myCourses = null;
            mySchool.Courses = myCourses;
        }
    }
}
