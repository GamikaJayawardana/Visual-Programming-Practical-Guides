using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_05_02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            btnOk.Visible = false;
            int value = 0;
            progressBar1.Visible = true;
            do
            {
                progressBar1.Value = value;
                value = value + 1;
            }
            while (value < progressBar1.Maximum);
            MessageBox.Show("Registration Completed", "Congradulations!");
        }
    }
}
