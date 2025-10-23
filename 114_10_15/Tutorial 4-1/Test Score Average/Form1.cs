using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Score_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = double.Parse(test1TextBox.Text);
                double score2 = double.Parse(test2TextBox.Text);
                double score3 = double.Parse(test3TextBox.Text);

                double average = (score1 + score2 + score3) / 3.0;

                averageLabel.Text = average.ToString("0.00");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入正確的數字格式！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";

            test1TextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
