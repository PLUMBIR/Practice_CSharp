namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double argX = double.Parse(textBox1.Text);
                double argY = double.Parse(textBox2.Text);
                double argZ = double.Parse(textBox3.Text);

                double result = Math.Abs(Math.Cos(argX) - Math.Cos(argY)) + 2 * Math.Pow(Math.Sin(0.5), 2) * (1 + Math.Pow(argZ, 2) / 2 + Math.Pow(argZ, 3) / 3 + Math.Pow(argZ, 4) / 4); ;

                textBox4.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("Неправильный формат аргументов!");
                return;
            }
        }
    }
}
