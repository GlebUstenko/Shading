using System;
using System.Collections.Generic;
using System.Drawing;

namespace Cg1Model
{
    public abstract class VisualizableShape : Shape
    {
        protected VisualizableShape(IEnumerable<Vector> points) : this(SelectPointsToArray(points))
        {

        }

        protected VisualizableShape(Vector[] points) : base(points)
        {
            Normal = CalculateNormal(points);
        }

        protected static Vector CalculateNormal(IList<Vector> points)
        {
            var a = CalculateNormal(points[0], points[1], points[2]).Normalize();
            var b = (-points[1]).Normalize();
            var result = (a.X*b.X + a.Y*b.Y + a.Z*b.Z);
            return result > 0 ? a : -a;
        }

        public Vector Normal
        {
            get
            {
                return _normal.Normalize();
            }
            set
            {
                _normal = value;
            }
        }

        public override bool IsVisible
        {
            get
            {
                return Normal.Z <= 0;
            }
        }

        public static Vector CalculateNormal(Vector a, Vector b, Vector c)
        {
            var x = a - b;
            var y = c - b;
            return x*y;
        }

        private Vector _normal;

       
        public void RecalculateNormal()
        {
            Normal = CalculateNormal(Points);
        }
    }
}
