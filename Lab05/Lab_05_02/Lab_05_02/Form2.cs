using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_05_02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string country = txtCountry.Text;
                string gender;

                if (age < 15 && age > 70)
                {
                    throw new InvalidAgeRangeException("Sorry, You should be  older than 15 and younger than 70 to register our university"); 
                }
                if (Female.Checked == true)
                {
                    gender = "Female";
                }
                else if (Male.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    throw new GenderException("Should Select a gender from the  radio buttons"); 
                }
                Form3 frm3 = new Form3();
                frm3.Show();
            }
            catch (InvalidAgeRangeException e1)
            {
                MessageBox.Show(e1.ToString(), "Can't Register!");
            }
            catch (GenderException e1)
            {
                MessageBox.Show(e1.ToString(), "Warning!");
            }
            catch (FormatException e1)
            {
                MessageBox.Show(e1.ToString(), "Enter a Numerical Value to the  Age"); 
            }
        }
    }

    public class InvalidAgeRangeException : Exception
    {
        public InvalidAgeRangeException(string message)
        : base(message)
        {
        }
    }

    public class GenderException : Exception
    {
        public GenderException(string message)
        : base(message)
        {
        }
    }
}
