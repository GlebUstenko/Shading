using System.Linq;
using Cg1Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ModelTests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod]
        public void TestNormal()
        {
            const double crystalProportionY = 0.1;
            const double cos30 = 0.8660254037844386;
            const double sin30 = 0.5;

            Vector[] crystalElement =
            {
                new Vector(0, 1, 0),
                new Vector(-sin30, crystalProportionY, cos30),
                new Vector(0, -crystalProportionY, 1)
            };


            var shape = new Triangle(crystalElement);
          //  var norm = VisualizableShape.Normal(shape.A, shape.B, shape.C);

        }

        [TestMethod]
        public void TestVectorItself()
        {
            var a = new Vector(1, 2, 3);

            var result = a*a;
            Assert.AreEqual(result.X, 0);
            Assert.AreEqual(result.Y, 0);
            Assert.AreEqual(result.Z, 0);
        }

        [TestMethod]
        public void TestVectorAnticom()
        {
            var a = new Vector(1, 2, 3);
            var b = new Vector(2, 3, 4);
            var ab = a * b;
            var ba = b*a;
            Assert.IsTrue(ab == -ba);
        }

        [TestMethod]
        public void TestVectorMult()
        {
            var a = new Vector(-1, 2, -3);
            var b = new Vector(0, -4, 1);
            var result = a*b;
            Assert.AreEqual(result.X, -10);
            Assert.AreEqual(result.Y, 1);
            Assert.AreEqual(result.Z, 4);
        }

        [TestMethod]
        public void HasInvisible()
        {
            var shape = new DeltoidalIcositetrahedron(new Vector(100, 100, 100), 100, 100, 100);
            int count = shape.Shapes.Count(x => !x.IsVisible);
            Assert.IsTrue(count > 0, "inizs");
        }
    }
}
