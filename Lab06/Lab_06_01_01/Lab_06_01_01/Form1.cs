namespace Lab_06_01_01
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();

            int num1, num2, num3;
            bool isNum3Empty = string.IsNullOrEmpty(txtNum3.Text);


            if(int.TryParse(txtNum1.Text, out num1) && int.TryParse(txtNum2.Text, out num2)) {
                if (isNum3Empty)
                {
                    int result = calc.Add(num1, num2);
                    lblResult.Text = $"Sum of two numbers: {result}";
                }

                else if (int.TryParse(txtNum3.Text, out num3))
                {
                    int result = calc.Add(num1, num2, num3);
                    lblResult.Text = $"Sum of three numbers: {result}";
                }
                else
                {
                    lblResult.Text = "invalid input in third number";
                }
            }
            else
            {
                lblResult.Text = "Invalid input in first two numbers";
            }
        }
    }
}