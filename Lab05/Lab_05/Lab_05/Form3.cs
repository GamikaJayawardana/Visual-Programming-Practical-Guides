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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string fullstrg = textBox1.Text;
                string substrg = fullstrg.Substring(0, 4);
                MessageBox.Show("First Three letters of the name is " +
                substrg);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Enter a name at least have three characters"); 
            }
        }
    }
}
