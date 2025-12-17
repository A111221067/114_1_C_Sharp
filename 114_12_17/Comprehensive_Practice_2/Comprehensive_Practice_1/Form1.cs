using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comprehensive_Practice_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnShowHighest_Click(object sender, EventArgs e)
        {
            string surname = txtFirstName.Text;
            string givenName = txtLastName.Text;

            int quiz1, quiz2, quiz3;
            if(int.TryParse(txtQuiz1.Text, out quiz1)&&
               int.TryParse(txtQuiz2.Text, out quiz2)&&
               int.TryParse(txtQuiz3.Text, out quiz3))
            {
                showResult(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("請輸入有效的分數（整數）", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearTextBoxes();
            }
           
        }

        private void showResult(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore = 0;
            
            highestScore = findHighestScore(quiz1, quiz2, quiz3);

            lblResult.Text = string.Format("{0} {1} 的最高分是 {2} 分", surname, givenName, highestScore);
        }

        private int findHighestScore(int quiz1, int quiz2, int quiz3)
        {
            int highestScore;
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }  
            return highestScore;
        }

        private void clearTextBoxes()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtQuiz1.Clear();
            txtQuiz2.Clear();
            txtQuiz3.Clear();
            txtFirstName.Focus(); 
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
