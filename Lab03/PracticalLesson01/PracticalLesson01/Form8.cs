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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.SelectedText = "Sri Lankan Cities" + Environment.NewLine +Environment.NewLine;
            richTextBox1.SelectedText = "Colombo" + Environment.NewLine;
            richTextBox1.SelectedText = "Kandy" + Environment.NewLine;
            richTextBox1.SelectedText = "Galle" + Environment.NewLine;
            richTextBox1.SelectedText = "Ampara" + Environment.NewLine;
            richTextBox1.SelectedText = "Ratnapura" + Environment.NewLine;
        }
    }
}
