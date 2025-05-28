using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CricMatch
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m01.Text == "Win")
            {
                if (m02.Text == "Win")
                {
                    title.Text = "Champion";
                }
                else
                {
                    title.Text = "Attacker";
                }
            }
            else
            {
                if (m02.Text == "Win")
                {
                    title.Text = "Attacker";
                }
                else
                {
                    title.Text = "Sportsman";
                }
            }

        }
    }
}