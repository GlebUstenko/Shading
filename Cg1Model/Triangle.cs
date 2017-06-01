using System;

namespace Cg1Model
{
    public class Triangle : VisualizableShape
    {

        public Triangle(params Vector[] points) : base(points)
        {
            if (points.Length != 3)
                throw new ArgumentException();
        }
    }
}
