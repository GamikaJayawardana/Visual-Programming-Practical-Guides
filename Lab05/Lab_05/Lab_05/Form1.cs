namespace Lab_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtnum1.Text);
                int num2 = int.Parse(txtnum2.Text);
                int num3 = num1 + num2;
                MessageBox.Show(num3.ToString());
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }
    }
}
