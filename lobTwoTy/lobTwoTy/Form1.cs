namespace lobTwoTy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int k = Convert.ToInt32((sender as Button).Tag);
            string s = "You pressed the button";
            switch (k)
            {
                case 1:
                    s += "number1 ";
                    break;
                case 2:
                    s += "number2";
                    break;
                default:
                    s = "You couldn't get here";
                    break;

            }
            MessageBox.Show(this, s, "Which button?");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i>this.Controls.Count;  i++)
            {
                if (Convert.ToString(this.Controls[i].GetType().Name) == "Butoon")
                {
                    MessageBox.Show(this, Convert.ToString(this.Controls[i].Name), "What buttonsare there?");
                }
            }
        }
    }
}