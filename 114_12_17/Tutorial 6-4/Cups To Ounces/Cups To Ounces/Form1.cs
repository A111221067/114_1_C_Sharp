using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CupsToOunces(double cups)
        {
            return cups * 8.0;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double cups = 0;
            double ounces = 0;

            bool isValid = double.TryParse(cupsTextBox.Text, out cups);

            if (!isValid)
            {
                MessageBox.Show("請輸入有效的數字。", "輸入錯誤");
                return;
            }

            ounces = CupsToOunces(cups);
            ouncesLabel.Text = ounces.ToString("n2") + " 盎司";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
