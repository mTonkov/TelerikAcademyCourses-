using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountGivenNumber;

namespace CountGivenNumberUnitTesting
{
    [TestClass]
    public class CountGivenNumberUnitTesting
    {
        static int[] arrayOfNumbers = { 5, 4, 2, 3, 65, 3, 5, 4, 4, 8, 9, 7, 5, 5, 7, 7, 633, 4, 5, 1, 2, 23, 2, 1, 4, 2, 3 };

        [TestMethod]
        public void TestWithNumbersInArray()
        {
            int result = CountNumber.CountNumberAppearance(4, arrayOfNumbers);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestWithMultiDigitNumber()
        {
            int result = CountNumber.CountNumberAppearance(633, arrayOfNumbers);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestWithNotInArrayNumber()
        {
            int result = CountNumber.CountNumberAppearance(456321789, arrayOfNumbers);
            Assert.AreEqual(0, result);
        }
    }
}
