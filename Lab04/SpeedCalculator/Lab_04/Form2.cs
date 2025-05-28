using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCal(object sender, EventArgs e)
        {
            double minutes = double.Parse(txtTime.Text);
            double distance = double.Parse(txtDistance.Text);
            double hours = 0, speed;

            hours = minutes / 60;

            speed = getSpeed(distance, hours);

            MessageBox.Show("Your speed is " + speed + " Kilometers per hour", "Speed", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); 
}

        public double getSpeed(double hours, double distance)
        {
            double speed = distance / hours;
            return speed;
        }
    }
}
