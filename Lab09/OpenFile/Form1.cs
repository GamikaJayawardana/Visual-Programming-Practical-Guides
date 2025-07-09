using System.Diagnostics;

namespace OpenFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                string file1 = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(file1))
                {
                    MessageBox.Show("Please select a file to open");
                    return;
                }

                string filePath = @"D:\(D) Documents\Lessons\Year 03 Sem 01\BECS 31242 - Visual Programming\Visual Programming Practical Guides\Lab09\OpenFile\TextFiles\" + file1 + ".txt";

                var psi = new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                };

                Process.Start(psi);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error opening file: " + ex.Message);
            }
        }
    }
}
