using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(txtDividend.Text);
                int num2 = int.Parse(txtDivisor.Text);
                int num3 = num1 / num2;
                MessageBox.Show(num3.ToString());
            }
            catch (FormatException e1)
            {
                MessageBox.Show("Enter Numbers to both text boxes"+ Environment.NewLine+ e1.ToString()); 
            }
            catch (DivideByZeroException e2)
            {
                MessageBox.Show("Numbers can't be divide by zero" + Environment.NewLine + e2.ToString());
            }
        }
    }
}
