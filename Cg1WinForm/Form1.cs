using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cg1Model;
using Helpers;

namespace Cg1WinForm
{
    public partial class Form1 : Form, IMessageFilter
    {
        public Form1()
        {
            InitializeComponent();
            Application.AddMessageFilter(this);
            MouseWheel += (sender, args) => ProcessShape(s => s.Resize(1 + 0.1*Math.Sign(args.Delta)));
        }

        private void ProcessShape(Action<ComplexShape> action)
        {
            action(_shape);
            ShowChanges();
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x20a)
            {
                // WM_MOUSEWHEEL, find the control at screen position m.LParam
                var pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                IntPtr hWnd = WindowFromPoint(pos);
                if (hWnd != IntPtr.Zero && hWnd != m.HWnd && FromHandle(hWnd) != null)
                {
                    SendMessage(hWnd, m.Msg, m.WParam, m.LParam);
                    return true;
                }
            }
            return false;
        }

        // P/Invoke declarations
        [DllImport("user32.dll")]
        private static extern IntPtr WindowFromPoint(Point pt);

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


        private ComplexShape _shape;
        private const int MidX = 700, MidY = 350, MidZ = 100, ShapeWidth = 100, ShapeHeight = 270, ShapeLength = 100;
        private readonly Vector _center = new Vector(MidX, MidY, MidZ);

        private static readonly Pen GreenPen = new Pen(Color.Green, 3);
        private static readonly Pen PurplePen = new Pen(Color.MediumPurple, 3);

        private double AngleX
        {
            get
            {
                return GetAngle(xNUD);
            }
        }


        private double AngleY
        {
            get
            {
                return GetAngle(yNUD);
            }
        }

        private double AngleZ
        {
            get
            {
                return GetAngle(zNUD);
            }
        }

        private double GetAngle(NumericUpDown nud)
        {
            return (double) nud.Value*Math.PI/180;
        }

        private bool SubscritePoints
        {
            get
            {
                return subscribeCb.Checked;
            }
        }

        private void crystall1Btn_Click(object sender, EventArgs e)
        {
            _visualizer.Pen = PurplePen;
            _shape = new HexagonalTrapezohedron(_center, ShapeWidth, ShapeHeight, ShapeLength);
            DrawShape();
        }

        private IVisualizer _visualizer = new DefaultVisualizer(Pens.Black);

        private void crystall2Btn_Click(object sender, EventArgs e)
        {
            _visualizer.Pen = GreenPen;
            _shape = new DeltoidalIcositetrahedron(_center, 250);
            DrawShape();
        }

        private void DrawShape()
        {
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(pictureBox1.BackColor);
                _shape.Draw(g, _visualizer);
                pictureBox1.Refresh();
            }
        }

        readonly Brush _brush = Brushes.Red;
        Font _font;

        private void ShowChanges()
        {
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(pictureBox1.BackColor);
                _shape.Draw(g, _visualizer);
                if (SubscritePoints)
                {
                    char c = 'A';
                    foreach (var p in _shape.Points)
                    {
                        g.DrawString(c++.ToString(), _font, _brush, (float) (p.X + 10), (float) (p.Y + 10));
                    }
                }
            }
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            timer1.Interval = (int) numericUpDown2.Value;
            crystall1Btn.PerformClick();
            _font = new Font(Font.FontFamily, 12);
        }

        private void subscribeCb_CheckedChanged(object sender, EventArgs e)
        {
            ShowChanges();
        }

        private void autoAction_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = autoAction.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotateCenterBtn.PerformClick();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            bool enabled = timer1.Enabled;
            timer1.Stop();
            timer1.Interval = (int) numericUpDown2.Value;
            timer1.Enabled = enabled;
        }

        private void rotateCenterBtn_Click(object sender, EventArgs e)
        {
            if (xCheckBox.Checked)
                _shape.RotateCenterX(AngleX);
            if (yCheckBox.Checked)
                _shape.RotateCenterY(AngleY);
            if (zCheckBox.Checked)
                _shape.RotateCenterZ(AngleZ);
            ShowChanges();
        }

        private void reflectBtn_Click(object sender, EventArgs e)
        {
            if (xCheckBox.Checked)
                _shape.ReflectCenterX();
            if (yCheckBox.Checked)
                _shape.ReflectCenterY();
            if (zCheckBox.Checked)
                _shape.ReflectCenterZ();
            ShowChanges();
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            bool left = e.Button.HasFlag(MouseButtons.Left);
            bool right = e.Button.HasFlag(MouseButtons.Right);
            if (!(left || right))
            {
                _delta = e.Location;
                return;
            }
            double dx = e.Location.X - _delta.X;
            double dy = e.Location.Y - _delta.Y;
            Action<Shape> action = null;
            if (left)
                action = shape => shape.Move(dx, dy, 0);
            if (right)
                action += shape =>
                          {
                              shape.RotateCenterY(-dx/100.0);
                              shape.RotateCenterX(dy/100.0);
                          };
            ProcessShape(action);
            _delta = e.Location;
        }

        private Point _delta = Point.Empty;
        

        private void defaultVisualizerRb_CheckedChanged(object sender, EventArgs e)
        {
            SetNewVisualizer<DefaultVisualizer>();
        }
        
        private void normalVisualizerRb_CheckedChanged(object sender, EventArgs e)
        {
            SetNewVisualizer<NormalVisualizer>();
        }

        private void fillRb_CheckedChanged(object sender, EventArgs e)
        {
            SetNewVisualizer<FillVisualizer>();
        }

        private void SetNewVisualizer<T>() where T : DefaultVisualizer
        {
            _visualizer = _visualizer.Clone<T>();
            ShowChanges();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Производит инициализацию статических конструкторов в отдельном потоке.
            RuntimeHelper.InitInNewThread<FillVisualizer>();
            RuntimeHelper.InitInNewThread<DeltoidalIcositetrahedron>();
        }
    }
}