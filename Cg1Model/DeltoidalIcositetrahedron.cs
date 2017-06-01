using System;
using System.Linq;

namespace Cg1Model
{
    public class DeltoidalIcositetrahedron : ComplexShape
    {
        public DeltoidalIcositetrahedron(Vector center, int width, int height, int length)
            : base(EtalonShapes, center, width, height, length)
        {
        }

        public DeltoidalIcositetrahedron(Vector center, int size)
            : base(EtalonShapes,center, size, size, size)
        {
        }

        private const double RotDegree = Math.PI/2;
        private const double Gamma = 0.774;
        private static readonly double Beta = Math.Sqrt(2);

        private static readonly Vector[] CrystalElement =
        {
            new Vector(0, 0, Beta),
            new Vector(0, 1, 1),
            new Vector(Gamma, Gamma, Gamma),
            new Vector(1, 0, 1)
        };

        private static readonly VisualizableShape[] EtalonShapes = new VisualizableShape[6 * 4];

        static DeltoidalIcositetrahedron()
        {
            CreateEtalon();
            RemoveDuplicatePoints(EtalonShapes);
            EtalonShapes = EtalonShapes.SelectToArray(x =>
                                                      (VisualizableShape)
                                                      new Simplex(x.Points.SelectToArray(p => p/Beta)));
        }

        private static void CreateEtalon()
        {
            InvisibleShape[] segment = Segment;
            Array.Copy(segment, EtalonShapes, segment.Length);
            for (int i = 1; i < 3; i++)
            {
                segment = segment.SelectToArray(s => s.Clone<InvisibleShape>());
                foreach (var shape in segment)
                {
                    shape.RotateZ(RotDegree);
                    shape.RotateY(RotDegree);
                }
                Array.Copy(segment, 0, EtalonShapes, i*segment.Length, segment.Length);
            }
            var half = EtalonShapes.TakeWhile(x => x != null).Select(s => s.Clone<InvisibleShape>()).ToArray();
            foreach (var shape in half)
            {
                shape.ReflectX();
                shape.ReflectY();
                shape.ReflectZ();
            }
            Array.Copy(half, 0, EtalonShapes, half.Length, half.Length);
        }

        private static InvisibleShape[] Segment
        {
            get
            {
                var result = new InvisibleShape[4];
                var upperHalf = UpperHalf;
                Array.Copy(upperHalf, result, upperHalf.Length);

                var bottomHalf = BottomHalf;
                Array.Copy(bottomHalf, 0, result, upperHalf.Length, bottomHalf.Length);
                return result;
            }
        }

        private static InvisibleShape[] BottomHalf
        {
            get
            {
                var shapes = UpperHalf.SelectToArray(s => s.Clone<InvisibleShape>());
                foreach (var shape in shapes)
                {
                    shape.ReflectY();
                }
                return shapes;
            }
        }

        private static Shape[] UpperHalf
        {
            get
            {
                var shapes = new Shape[2];
                var shape = new InvisibleShape((Vector[]) CrystalElement.Clone());
                for (int i = 0; i < shapes.Length; i++)
                {
                    shapes[i] = new InvisibleShape(shape.Points);
                    shape.ReflectX();
                }
                return shapes;
            }
        }
    }
}
