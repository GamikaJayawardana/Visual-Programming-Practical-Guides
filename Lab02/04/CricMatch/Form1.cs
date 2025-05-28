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
            string result1;
            string result2;
            result1 = m01.Text;
            result2 = m02.Text;
            switch (result1)
            {
                case "win":
                    switch (result2)
                    {
                        case "win":
                            title.Text = "Champion";
                            break;
                        case "lose":
                            title.Text = "Attacker";
                            break;
                    }
                    break;
                case "lose":
                    switch (result2)
                    {
                        case "win":
                            title.Text = "Attacker";
                            break;
                        case "lose":
                            title.Text = "Sportsman";
                            break;
                    }
                    break;
            }
        }

    }
}