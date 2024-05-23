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
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];

            string digits = "";

            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    digits += c;
                }
            }

            label1.Text = "Цифры содержащиеся в строке: " + digits;

        }
    }
}
