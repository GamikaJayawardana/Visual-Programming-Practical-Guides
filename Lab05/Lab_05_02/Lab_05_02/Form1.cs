namespace Lab_05_02
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
                int noTaxThreshold = 11000;
                int band1 = 11000;
                int band2 = 43000;
                int band3 = 150000;
                decimal tax = 0;
                string msg = "Income need to be greater than 11000 to calcilate a tax";
                int salary = int.Parse(txtIncome.Text);
                if (salary < noTaxThreshold) throw new InvalidIncomeException(msg);
                if (salary >= band3)
                {
                    tax = (salary - noTaxThreshold) * (decimal)0.45;
                }
                if (salary > band2)
                {
                    tax = (salary - noTaxThreshold) * (decimal)0.40;
                }
                if (salary > band1)
                {
                    tax = (salary - noTaxThreshold) * (decimal)0.20;
                }

                txtTax.Text = tax.ToString();
            }
            catch (InvalidIncomeException e1)
            {
                MessageBox.Show(e1.ToString(), " Invalid Annual Income");
            }
            catch (FormatException e1)
            {
                MessageBox.Show(e1.ToString(), "Enter Numeric Value as Annual Income");
            }
            catch (System.OverflowException e1)
            {
                MessageBox.Show(e1.ToString(), "Too Large number to handle");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIncome.Clear();
            txtTax.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class InvalidIncomeException : Exception
    {
        public InvalidIncomeException(String message)
        : base(message)
        {
        }
    }
}
