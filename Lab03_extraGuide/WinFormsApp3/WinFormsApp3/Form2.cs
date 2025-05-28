using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message Box", "Visual Studio");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input1;
            input1 = Interaction.InputBox("This is an input box", "Title");
            label1.Text = input1;
        }
    }
}
