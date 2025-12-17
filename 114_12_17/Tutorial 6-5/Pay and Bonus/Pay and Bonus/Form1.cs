using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            bool validPay = decimal.TryParse(grossPayTextBox.Text, out pay);
            bool validBonus = decimal.TryParse(bonusTextBox.Text, out bonus);

            if (!validPay || !validBonus)
            {
                MessageBox.Show("請輸入有效的金額。", "輸入錯誤");
                return false;
            }

            return true;
        }


        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.


        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal pay = 0m;
            decimal bonus = 0m;

            if (InputIsValid(ref pay, ref bonus))
            {
                decimal totalIncome = pay + bonus;
                decimal contribution = totalIncome * CONTRIB_RATE;

                contributionLabel.Text = contribution.ToString("c");
            }
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
