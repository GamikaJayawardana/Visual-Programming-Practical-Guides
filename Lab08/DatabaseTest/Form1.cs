using System.Data;
using System.Data.SqlClient;

namespace DatabaseTest
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        string connectionString = "Data Source = GAMIKA\\SQLEXPRESS; Initial Catalog = DBproject1; Integrated Security = True;";


        private void loadData()
        {

            try
            {
                connection = new SqlConnection(connectionString);
                adapter = new SqlDataAdapter("SELECT * FROM Doctor", connection);
                dataTable = new DataTable();
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.AllowUserToDeleteRows = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dataTable);
                MessageBox.Show("Data updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            dataGridView1.DefaultCellStyle.SelectionBackColor =
            Color.MediumVioletRed;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Yellow;
        }
    }
}
