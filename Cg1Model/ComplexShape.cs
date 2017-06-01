using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Cg1Model
{
    public abstract class ComplexShape : VisualizableShape
    {
        protected override void OnProcessCenter(Action<Vector> action)
        {
            foreach (var shape in Shapes)
            {
                action(shape.Normal);
            }
        }

        private void ProcessAllShapes(Action<VisualizableShape> action)
        {
            foreach (var shape in Shapes)
            {
                action(shape);
            }
        }

        protected ComplexShape(ICollection<VisualizableShape> shapes, Vector center, int width, int height, int length)
            : this(shapes)
        {
            double[,] matrix =
            {
                {width, 0, 0},
                {0, height, 0},
                {0, 0, length}
            };


            ProcessAllPoints(p => p.AffineTransform(matrix));
            ProcessAllShapes(shape => shape.RecalculateNormal());
            ProcessAllPoints(p => p.Move(center));
        }

        protected ComplexShape(ICollection<VisualizableShape> shapes)
            : base(shapes.SelectMany(x => x.Points).Distinct())
        {
            Shapes = new VisualizableShape[shapes.Count];
            int i = 0;
            foreach (var shape in shapes)
            {
                Shapes[i++] = GetEqualPoints(shape);
            }
        }

        private VisualizableShape GetEqualPoints(Shape shape)
        {
            var result = shape.Clone<VisualizableShape>();
            for (int i = 0; i < result.Points.Length; i++)
            {
                result.Points[i] = Points.First(x => (x - shape.Points[i]).Length < double.Epsilon);
            }
            result.Normal = CalculateNormal(result.Points);
            return result;
        }

        protected static void RemoveDuplicatePoints(IEnumerable<Shape> shapes)
        {
            var points = new List<Vector>();
            foreach (var shape in shapes)
            {
                for (int i = 0; i < shape.Points.Length; i++)
                {
                    shape.Points[i] = TryGetExistingPoint(shape.Points[i], points);
                    points.Add(shape.Points[i]);
                }
            }
        }

        protected static Vector TryGetExistingPoint(Vector point, ICollection<Vector> points)
        {
            if (points.Count != 0)
            {
                double min = points.Min(p => (p - point).Length);
                if (Math.Round(min, 8) < Double.Epsilon)
                    return points.First(p => Math.Abs((p - point).Length - min) < Double.Epsilon);
            }
            return point;
        }

        public override bool IsVisible
        {
            get
            {
                return Shapes.Any(s => s.IsVisible);
            }
        }
        
        public void Resize(double x)
        {
            Resize(x, x, x);
        }
            

        public void Resize(double width, double height, double length)
        {
            double[,] matrix =
            {
                {width, 0, 0},
                {0, height, 0},
                {0, 0, length}
            };


            ProcessAllPointsInCenter(p => p.AffineTransform(matrix));
        }

        public VisualizableShape[] Shapes { get; private set; }
    }
}