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

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal MINIMUM_SALARY = 1200000m; 
                const int MINIMUM_YEARS = 2; 

                decimal salary; 
                int yearsOnJob;
                if (decimal.TryParse(salaryTextBox.Text, out salary))
                {
                    if (int.TryParse(yearsTextBox.Text, out yearsOnJob))
                    {
                        if (salary >= MINIMUM_SALARY && yearsOnJob >= MINIMUM_YEARS)
                        {
                            decisionLabel.Text = "符合資格。";
                        }
                        else
                        {
                            decisionLabel.Text = "不符合資格;年資未達最低標準";
                        }
                    }
                    else
                    {
                        decisionLabel.Text = "不符合資格;收入未未達最低標準";
                    }
                }
                else
                {
                    decisionLabel.Text = "不符合資格;收入未未達最低標準";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            salaryTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
