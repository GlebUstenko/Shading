using System;
using System.Linq;

namespace Cg1Model
{
    public class HexagonalTrapezohedron : ComplexShape
    {
        public HexagonalTrapezohedron(Vector center, int width, int height, int length)
            : base(EtalonShapes, center, width, height, length)
        {

        }

        private const int N = 12;
        private const double RotDegree = Math.PI/3;
        private const double CrystalProportionY = 0.1;
        private const double Cos30 = 0.8660254037844386;
        private const double Sin30 = 0.5;

        private static readonly Vector[] CrystalElement =
        {
            new Vector(0, 1, 0),
            new Vector(-Sin30, CrystalProportionY, -Cos30),
            new Vector(Sin30, CrystalProportionY, -Cos30),
            new Vector(0, -CrystalProportionY, -1)
        };



        private static readonly VisualizableShape[] EtalonShapes = new VisualizableShape[N];

        static HexagonalTrapezohedron()
        {
            CreateEtalon();

            RemoveDuplicatePoints(EtalonShapes);

            var getTriangles = EtalonShapes.SelectMany(s => new VisualizableShape[]
                                                            {
                                                                new Triangle(s.Points.Take(3).ToArray()),
                                                                new Triangle(s.Points.Skip(1).ToArray())
                                                            }).ToArray();
            EtalonShapes = getTriangles;
        }

        

        private static void CreateEtalon()
        {
            var bottomHalf = BottomHalf;
            Array.Copy(bottomHalf, EtalonShapes, bottomHalf.Length);

            var upperHalf = UpperHalf;
            Array.Copy(upperHalf, 0, EtalonShapes, bottomHalf.Length, upperHalf.Length);
        }

        private static Array UpperHalf
        {
            get
            {
                var shapes = BottomHalf.SelectToArray(s => s.Clone<InvisibleShape>());
                foreach (var shape in shapes)
                {
                    shape.ReflectY();
                    shape.RotateY(RotDegree/2);
                }
                return shapes;
            }
        }

        private static Shape[] BottomHalf
        {
            get
            {
                var shapes = new Shape[N/2];
                var shape = new InvisibleShape((Vector[]) CrystalElement.Clone());
                for (int i = 0; i < shapes.Length; i++)
                {
                    shapes[i] = new InvisibleShape(shape.Points);
                    shape.RotateY(RotDegree);
                }
                return shapes;
            }
        }
    }
}