using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal BASE_HOURS = 40m; 
            const decimal OVERTIME_RATE = 1.5m; 

            decimal hoursWorked;     
            decimal hourlyPayRate;    
            decimal grossPay;       

            if (decimal.TryParse(hoursWorkedTextBox.Text, out hoursWorked))
            {
                if (decimal.TryParse(hourlyPayRateTextBox.Text, out hourlyPayRate))
                {
                    if (hoursWorked <= BASE_HOURS)
                    {
                        grossPay = hoursWorked * hourlyPayRate;
                    }
                    else
                    {
                        grossPay = (BASE_HOURS * hourlyPayRate) +
                                   ((hoursWorked - BASE_HOURS) *
                                   (hourlyPayRate * OVERTIME_RATE));
                    }

                    grossPayLabel.Text = grossPay.ToString("c");
                }
                else
                {
                    MessageBox.Show("請輸入正確的時薪數值。", "輸入錯誤");
                }
            }
            else
            {
                MessageBox.Show("請輸入正確的工時數值。", "輸入錯誤");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
