namespace Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            {
            int n, first = 0, second = 1, next = 0, c;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a number to proceed", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                n = int.Parse(textBox1.Text);

                for (c = 0; c < n; c++)
                {
                    if (c <= 1)
                    {
                        next = c;

                    }
                    else
                    {
                        next = first + second;
                        first = second;
                        second = next;


                    }

                }

                lblDisplay.Text = n + " fibonacci number is: " + next;
            }
        }
    }
}
