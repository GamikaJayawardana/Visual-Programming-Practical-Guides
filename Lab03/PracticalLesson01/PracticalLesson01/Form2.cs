using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticalLesson01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            string language1;
            language1 = txtInput.Text;
            if (language1 == "Visual Programming" || language1 == "VISUAL PROGRAMMING")
            {
                MessageBox.Show("We have a winner");
            }
            else
            {
                MessageBox.Show(language1 + " is not a bad choice");
            }
            
        }
    }
}
