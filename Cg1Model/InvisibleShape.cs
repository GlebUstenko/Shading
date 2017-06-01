using System;
using System.Collections.Generic;

namespace Cg1Model
{
    public class InvisibleShape : VisualizableShape
    {
        public InvisibleShape(IEnumerable<Vector> points) : base(points)
        {
        }


        public override bool IsVisible
        {
            get
            {
                return false;
            }
        }
    }
}
