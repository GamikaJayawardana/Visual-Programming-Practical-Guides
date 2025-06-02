namespace Lab_06_01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtMarks.Clear();
            txtResult.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string studentName = txtName.Text;
                string[] parts = txtMarks.Text.Split(',');
                int[] marks = Array.ConvertAll(parts, int.Parse);

                if (marks.Length != 5)
                {
                    MessageBox.Show("Please enter exactly 5 marks.");
                    return;
                }

                Student s = new Student(studentName, marks);
                txtResult.Text = s.GetSummery();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Error: + ex.Message");
            }
        }
    }
}
