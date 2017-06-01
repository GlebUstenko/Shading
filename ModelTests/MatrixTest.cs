using Cg1Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelTests
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void TestMultiply()
        {

            double[,] d1 =
            {
                {1, 2, 3},
                {4, 5, 6}
            };

            double[,] d2 =
            {
                {7, 8},
                {1, 2},
                {3, 4}
            };

            Matrix mat1 = d1, mat2 = d2;

            var mat = mat1*mat2;

            Assert.AreEqual(mat.GetLength(0), 2);
            Assert.AreEqual(mat.GetLength(1), 2);

            Assert.AreEqual(mat[0, 0], 18);
            Assert.AreEqual(mat[0, 1], 24);
            Assert.AreEqual(mat[1, 0], 51);
            Assert.AreEqual(mat[1, 1], 66);
        }

        [TestMethod]
        public void RotateTest()
        {
            var point = new Vector(40, 60, 80);
            point.RotateX(10);
        }
    }
}