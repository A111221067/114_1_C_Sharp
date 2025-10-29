using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleConditionsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("請輸入有效的整數成績", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtScore.Focus();
                return;
            }

            string grade;
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "E";
            }

            lblGrade.Text = grade;
        }

    }
}
