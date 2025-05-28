namespace SpeedCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double minutes = double.Parse(txtTime.Text);
            double distance = double.Parse(txtDistance.Text);
            double hours = 0, speed;

            hours = minutes / 60;

            speed = getSpeed(hours, distance);

            MessageBox.Show("Your speed is " + speed + " Kilometers per hour", "Speed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
}

        public double getSpeed(double hours, double distance)
        {
            double speed = distance / hours;
            return speed;
        }
    }
}
