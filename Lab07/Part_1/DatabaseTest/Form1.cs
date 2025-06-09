using System.Data.SqlClient;
using System.Data;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=GAMIKA\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";


            string sql = "SELECT * FROM Students";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

            DataSet ds = new DataSet();

            try
            {
                connection.Open();
                adapter.Fill(ds);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
