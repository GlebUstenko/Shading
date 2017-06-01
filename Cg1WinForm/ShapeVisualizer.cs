using System.Drawing;
using Cg1Model;

namespace Cg1WinForm
{
    public static class ShapeVisualizer
    {
        public static void Draw(this ComplexShape shape, Graphics g, IVisualizer visualizer)
        {
            foreach (var s in shape.Shapes)
            {
                visualizer.Draw(g, s);
            }
        }
    }
}