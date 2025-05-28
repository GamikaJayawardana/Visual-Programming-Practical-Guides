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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            lstMaster.Items.Add("Germany");
            lstMaster.Items.Add("France");
            lstMaster.Items.Add("United Kingdom");
            lstMaster.Items.Add("Italy");
            lstMaster.Items.Add("Spain");
            lstMaster.Items.Add("Switzerland");
            lstMaster.Items.Add("Netherlands");
            lstMaster.Items.Add("Greece");
            lstMaster.Items.Add("Poland");
            lstMaster.Items.Add("Austria");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int x, y;
            y = 0;
            x = lstMaster.CheckedItems.Count - 1;
            do
            {
                MessageBox.Show(lstMaster.CheckedItems[y].ToString());
                y = y + 1;
            } while (y <= x);
        }
    }
}
