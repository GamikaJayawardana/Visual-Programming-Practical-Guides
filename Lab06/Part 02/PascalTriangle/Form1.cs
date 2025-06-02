namespace PascalTriangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            try
            {
                int length = int.Parse(txtNumber.Text);
                long[][] triangle = new long[length + 1][];
                for (int row = 0; row < length; row++)
                {
                    triangle[row] = new long[row + 1];
                }
                // Calculate the Pascal's triangle 
                triangle[0][0] = 1;
                for (int row = 0; row < length - 1; row++)
                {
                    for (int col = 0; col <= row; col++)
                    {
                        triangle[row + 1][col] += triangle[row][col];
                        triangle[row + 1][col + 1] += triangle[row][col];
                    }
                }
                // Print the Pascal's triangle 
                for (int row = 0; row < length; row++)
                {
                    richTextBox1.Text = richTextBox1.Text + "".PadLeft((length - row) * 2);
                    for (int col = 0; col <= row; col++)
                    {
                        richTextBox1.Text = richTextBox1.Text + triangle[row][col];
                    }
                    richTextBox1.Text = richTextBox1.Text + Environment.NewLine;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number to the length");
            }
        }
    }
}
