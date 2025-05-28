namespace Vovels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String letter = lettertxt.Text;

            switch (letter)
            {
                case "A": 
                    MessageBox.Show("The Letter A is a Vowel");
                    break;
                case "E":
                    MessageBox.Show("The Letter E is a Vowel");
                    break;
                case "I":
                    MessageBox.Show("The Letter I is a Vowel");
                    break;
                case "O":
                    MessageBox.Show("The Letter O is a Vowel");
                    break;
                case "U":
                    MessageBox.Show("The Letter U is a Vowel");
                    break;
                case "a":
                    MessageBox.Show("The Letter A is a Vowel");
                    break;
                case "e":
                    MessageBox.Show("The Letter E is a Vowel");
                    break;
                case "i":
                    MessageBox.Show("The Letter I is a Vowel");
                    break;
                case "o":
                    MessageBox.Show("The Letter O is a Vowel");
                    break;
                case "u":
                    MessageBox.Show("The Letter U is a Vowel");
                    break;
                default:
                    MessageBox.Show("The Letter is not a Vowel");
                    break;


            }
        }
    }
}