namespace labThreeTy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString((Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)) / Convert.ToDouble(textBox3.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) *10/100);
            if (radioButton2.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 20 / 100);
            if (radioButton3.Checked == true)
                textBox5.Text = Convert.ToString(Convert.ToDouble(textBox4.Text) * 50 / 100);
            
        }
    }
}