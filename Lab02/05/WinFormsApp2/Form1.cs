namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 10)
            {
                richTextBox1.Text = richTextBox1.Text + "\n" + i;
                i++;
            }
        }
    }
}
