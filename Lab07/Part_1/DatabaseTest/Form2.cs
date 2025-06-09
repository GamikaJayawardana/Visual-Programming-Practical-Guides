using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;


namespace DatabaseTest
{
    public partial class Form2 : Form
    {
        private BindingSource bindingSource = new();
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private SqlConnection connection;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection("Data Source=GAMIKA\\SQLEXPRESS;Initial Catalog=DBproject1;Integrated Security=True");
            adapter = new SqlDataAdapter("SELECT * FROM Doctor", connection);

            dataTable = new DataTable();
            adapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;
            txtIndexNo.DataBindings.Clear();
            txtName.DataBindings.Clear();

            txtIndexNo.DataBindings.Add("Text", bindingSource, "DoctorID");
            txtName.DataBindings.Add("Text", bindingSource, "Name");
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bindingSource.MoveFirst();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bindingSource.MoveLast();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }
    }
}
