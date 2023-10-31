namespace labFiveTy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "" + textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Lines = new string[] { "Line 1", "Line 2" };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll(); // select all text
            textBox1.Cut(); // cut out what was selected

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; // in this line we assign an empty line.
        }
    }
}