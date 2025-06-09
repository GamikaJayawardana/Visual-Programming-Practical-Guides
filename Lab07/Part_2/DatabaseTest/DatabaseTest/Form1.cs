using System.Data;
using System.Data.SqlClient;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {

        string connectionString = "Data Source=GAMIKA\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

        private void LoadData()
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ClearFields()
        {
            txtIndexNo.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtCity.Clear();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "INSERT INTO Students (IndexNO, Name, Age, City) VALUES (@IndexNo, @Name, @Age, @City)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IndexNo", txtIndexNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
            ClearFields();
        }

        private void btnUpadate_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "UPDATE Students SET Name=@Name, Age=@Age City=@City WHERE IndexNo=@IndexNo"; ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IndexNo", txtIndexNo.Text);
            cmd.Parameters.AddWithValue("@Name", txtName.Text);
            cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            string sql = "DELETE FROM Students WHERE IndexNo=@IndexNo";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IndexNo", txtIndexNo.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            LoadData();
            ClearFields();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIndexNo.Text = dataGridView1.Rows[e.RowIndex].Cells["IndexNO"].Value.ToString();
                txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells["Age"].Value.ToString();
                txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells["City"].Value.ToString();

            }
        }
    }
}
