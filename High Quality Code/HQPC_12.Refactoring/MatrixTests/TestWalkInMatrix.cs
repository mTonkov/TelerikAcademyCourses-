namespace MatrixTests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Text;
    using WalkingInMatrix;

    [TestClass]
    public class TestWalkInMatrix
    {
        [TestMethod]
        public void TestPrintMatrix()
        {
            int[,] matrix = new int[3, 3] { {1, 0, 0 },
                                           {0, 2, 0 },
                                           {0, 0, 3 }};
            string matrixTostrng = "  1  0  0\r\n  0  2  0\r\n  0  0  3\r\n";
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            WalkingInMatrix.WalkInMatrix.PrintMatrix(matrix);
            Assert.AreEqual(matrixTostrng, sb.ToString(), "PrintMatrix not available.");
        }

        [TestMethod]
        public void TestMainMetod()
        {
            string matrixSize = "6";
            Console.SetIn(new System.IO.StringReader(matrixSize));
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            WalkingInMatrix.WalkInMatrix.Main();
            string matrixTostrng = @"Enter the size of the matrix:
  1 16 17 18 19 20
 15  2 27 28 29 21
 14 31  3 26 30 22
 13 36 32  4 25 23
 12 35 34 33  5 24
 11 10  9  8  7  6
";

            Assert.AreEqual(matrixTostrng, sb.ToString(), "PrintMatrix not available.");
        }

        [TestMethod]
        //TestInputNumberIsEqualToMatrixSize
        public void TestMainMetodWithIncorrectMatrixSize()
        {
            string matrixSize = "gr\r\n6";
            Console.SetIn(new System.IO.StringReader(matrixSize));
            StringBuilder sb = new StringBuilder();
            Console.SetOut(new System.IO.StringWriter(sb));
            WalkingInMatrix.WalkInMatrix.Main();
            string matrixTostrng = @"Enter the size of the matrix:
Please enter a number in the range [1, 100]
  1 16 17 18 19 20
 15  2 27 28 29 21
 14 31  3 26 30 22
 13 36 32  4 25 23
 12 35 34 33  5 24
 11 10  9  8  7  6
";

            Assert.AreEqual(matrixTostrng, sb.ToString(), "PrintMatrix not available.");
        }
    }
}
