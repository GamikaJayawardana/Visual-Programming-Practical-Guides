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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int intvalue = 0;
            progressBar1.Maximum = 10000;
            do
            {
                progressBar1.Value = intvalue;
                intvalue = intvalue + 1;
            } while (intvalue != 10000);
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
