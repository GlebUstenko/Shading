using System;

namespace Cg1Model  
{
    public class Simplex : VisualizableShape
    {
        public Simplex(params Vector[] points)
            : base(points)
        {
            if (points.Length != 4)
                throw new ArgumentException();
        }
    }
}
