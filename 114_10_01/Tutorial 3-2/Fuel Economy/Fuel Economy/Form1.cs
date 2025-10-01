using System;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles, gallons, mpg;

            if (double.TryParse(milesTextBox.Text, out miles) &&
                double.TryParse(gallonsTextBox.Text, out gallons) &&
                miles > 0 &&
                gallons > 0)
            {
                mpg = miles / gallons;
                mpgLabel.Text = $"每加侖英里數: {mpg:F2}";
            }
            else
            {
                MessageBox.Show("請輸入有效的正數。", "輸入錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
