namespace OOP_laba_1
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class MainForm : Form
    {
        private Shape[] _shapes;
        public MainForm()
        {
            InitializeComponent();

            // Создаем правильный многоугольник (например, шестиугольник)
            _shapes = new Shape[]
           {
                new Line(Color.Red, 2, new Point(50, 100), new Point(100, 100)), 
                new Polygon(Color.Blue, 2, new PointF(50, 150), 3, 10), 
                new Rectangle(Color.Green, 2, new PointF(50, 250), 40, 50),
                new Ellipse(Color.Purple, 2, new PointF(60, 360), 10, 30), 
                new Polyline(Color.Orange, 2, new Point[] { new Point(50, 490), new Point(100, 450), new Point(150, 480), new Point(200, 430) }) // Оранжевая ломаная
           };
        }

        

       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }
        }
    }
}
