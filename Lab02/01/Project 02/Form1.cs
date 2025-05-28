namespace Project_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (float.Parse(hours.Text) <= 40)
            {
                rate.Text = "100 LKR per hour";
            }
            else
            {
                rate.Text = "150 LKR per hour";
            }
        }

        private void hours_TextChanged(object sender, EventArgs e)
        {
            1
        }
    }
}