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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            TreeNode cnode, cnode1;
            treeView1.Nodes.Clear();
            cnode = treeView1.Nodes.Add("Managing Director");
            cnode.Nodes.Add("Accountant");
            cnode.Nodes.Add("Engineer");
            cnode.Nodes.Add("Adminitrator");
            cnode.Nodes.Add("Auditor");
            cnode.Nodes.Add("Stores Manager");
            cnode1 = cnode.Nodes[0];
            cnode1.Nodes.Add("Asst Accountant");
            cnode1.Nodes.Add("Accountant Asst");
            cnode1.Nodes.Add("Cashier");
            cnode1 = cnode.Nodes[1];
            cnode1.Nodes.Add("Engineering Asst");
            cnode1.Nodes.Add("Draughtman");
            cnode1 = cnode.Nodes[2];
            cnode1.Nodes.Add("Transport Officer");
            cnode1.Nodes.Add("Leave Cleark");
            cnode1 = cnode.Nodes[3];
            cnode1.Nodes.Add("Audit Cleark");
            cnode1 = cnode.Nodes[4];
            cnode1.Nodes.Add("Store Keeper");
            cnode1.Nodes.Add("Store Cleark");
            cnode1.Nodes.Add("Store Worker");
            cnode.Expand();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            imageList1.Images.Add(Image.FromFile("C:\\Users\\gamik\\Downloads\\OIP.jpeg"));
            treeView1.ImageList = imageList1;
        }
    }
}
