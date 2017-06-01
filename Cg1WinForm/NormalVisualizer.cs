using System.Drawing;
using System.Windows.Forms;
using Cg1Model;

namespace Cg1WinForm
{
    public class NormalVisualizer : DefaultVisualizer
    {
        public NormalVisualizer(Pen pen) : base(pen)
        {
        }
        
        public override void Draw(Graphics graphics, VisualizableShape shape)
        {
            if (shape.IsVisible)
                base.Draw(graphics, shape);
            //var point = shape.Center;
            //var y2 = (float) (point.Y - 100*shape.Normal.Y);
            //var x2 = (float)(point.X - 100 * shape.Normal.X);
            //graphics.DrawLine(new Pen(Brushes.Red, 5), (float)point.X, (float)point.Y, x2,
            //                  y2);

            //graphics.DrawString(string.Format("{0:f} {1:f} {2:f}", shape.Normal.X, shape.Normal.Y, shape.Normal.Z),
            //                    font, Brushes.Chocolate, x2, y2);
        }

      //  static readonly Font font = new Form().Font;
    }
}