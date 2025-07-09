namespace FileReadWrite_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.Beige;
            richTextBox1.ForeColor = Color.CornflowerBlue;
            richTextBox1.Text = "Contents of the file will display here";
            richTextBox1.Font = new Font("Segoe Print", 9);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string file1 = comboBox1.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(file1))
                {
                    MessageBox.Show("Please select a file to open");
                    return;
                }

                richTextBox1.Clear();
                richTextBox1.BackColor = Color.LightSeaGreen;
                richTextBox1.ForeColor = Color.WhiteSmoke;
                richTextBox1.Font = new Font("Times New Roman", 12);

                // Pass the file path and file name to the StreamReader constructor.
                StreamReader sr = new StreamReader("D:\\(D) Documents\\Lessons\\Year 03 Sem 01\\BECS 31242 - Visual Programming\\Visual Programming Practical Guides\\Lab09\\FileReadWrite\\TextFiles\\" + file1 +".txt");

                // Read the first line of text.
                string line = sr.ReadLine();

                // Continue to read until you reach the end of the file.
                while (line != null)
                {
                    // Write the file to the rich text box.
                    richTextBox1.Text = richTextBox1.Text + line + Environment.NewLine;

                    // Read the next line.
                    line = sr.ReadLine();
                }

                // Close the file.
                sr.Close();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Exception: " + e1.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    //Pass the filepath and filename to the StreamWriter Constructor  
                    StreamWriter sw = new StreamWriter("D:\\(D) Documents\\Lessons\\Year 03 Sem 01\\BECS 31242 - Visual Programming\\Visual Programming Practical Guides\\Lab09\\FileReadWrite\\TextFiles\\Write.txt");  
                    //Write a line of text 
                    sw.WriteLine("Hello!!!");
                    //Write a second line of text
                    sw.WriteLine("Good Morning…");  
                    //Write a third line of text  
                    sw.WriteLine("Welcome to Visual Programming.");
                    //Close the file 
                    sw.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show("Exception: " +
                    e1.Message);
                }
            }
        }
    }
}
