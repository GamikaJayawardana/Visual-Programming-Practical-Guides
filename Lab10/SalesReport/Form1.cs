using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace SalesReport
{
    public partial class Form1 : Form
    {
        string connStr = "Server=GAMIKA\\SQLEXPRESS;Database=SalesDB1;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private List<SalesData> GetSalesData()
        {
            var list = new List<SalesData>();


            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT ProductName, Quantity FROM Sales";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SalesData
                        {
                            ProductName = reader.GetString(0),
                            Quantity = reader.GetInt32(1)
                        });
                    }
                }
            }
            return list;
        }

        private List<TotalSalesData> GetTotalSalesData()
        {
            var list = new List<TotalSalesData>();

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT ProductName, Price*Quantity FROM Sales";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TotalSalesData
                        {
                            ProductName = reader.GetString(0),
                            Total = reader.GetDecimal(1)
                        });
                    }
                }
            }
            return list;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };
            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath = "D:\\(D) Documents\\Lessons\\Year 03 Sem 01\\BECS 31242 - Visual Programming\\Visual Programming Practical Guides\\Lab10\\SalesReport\\SalesReport.rdlc"; 
            reportViewer.LocalReport.DataSources.Clear();


            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1",GetSalesData()));
            reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2",GetTotalSalesData()));

            reportViewer.RefreshReport();
        }
    }

        public class SalesData
        {
            public string ProductName { get; set; }
            public int Quantity { get; set; }
        }

        public class TotalSalesData
        {
            public string ProductName { get; set; }
            public decimal Total { get; set; }
        }
    
}

