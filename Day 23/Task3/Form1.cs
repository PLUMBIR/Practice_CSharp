namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightBlue;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            Pen pen = new Pen(Color.Black, 2f);
            Brush brush = new SolidBrush(Color.Green);

            Point[] crownPoints = {
                new Point(200, 50), 
                new Point(150, 200), 
                new Point(250, 200) 
            };

            g.FillPolygon(brush, crownPoints);

            g.FillRectangle(brush, new Rectangle(195, 200, 10, 50));

            pen.Dispose();
            brush.Dispose();
        }
    }
}
