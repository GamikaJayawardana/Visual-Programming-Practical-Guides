using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=GAMIKA\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Students", connection);
                DataTable dataTable = new DataTable();

                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void clearField()
        {
            txtIndexNo.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);

                string sql = "INSERT INTO Students (IndexNo,Name,Age,City) Values (@IndexNo, @Name,@Age,@City)";

                using SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@IndexNo", txtIndexNo.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Age",int.Parse(txtAge.Text.Trim()));
                cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());

                connection.Open();
                cmd.ExecuteNonQuery();
                loadData();
                clearField();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection connection = new SqlConnection(connectionString);

                string sql = "UPDATE Students SET Name = @Name, Age =@Age, City = @City WHERE IndexNo = @IndexNo";

                using SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@IndexNo", txtIndexNo.Text.Trim());
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text.Trim()));
                cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());

                connection.Open();
                cmd.ExecuteNonQuery();
                loadData();
                clearField();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                txtIndexNo.Text = dataGridView1.Rows[e.RowIndex].Cells["IndexNo"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells["City"].Value.ToString();
            }
        }
    }
}
