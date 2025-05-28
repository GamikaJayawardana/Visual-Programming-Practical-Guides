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
            do
            {
                if (i == 5)
                {
                    i++;
                    continue;
                }
                richTextBox1.Text = richTextBox1.Text + "\n" + i;
                i++;
            }
            while (i < 10);
        }
    }
}
