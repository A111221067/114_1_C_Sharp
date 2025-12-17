using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
            decimal[,] prices = {
        { 450m, 450m, 450m, 450m }, 
        { 425m, 425m, 425m, 425m }, 
        { 400m, 400m, 400m, 400m }, 
        { 375m, 375m, 375m, 375m }, 
        { 375m, 375m, 375m, 375m }, 
        { 350m, 350m, 350m, 350m }  };

            int row, col;

            if (int.TryParse(rowTextBox.Text, out row) && int.TryParse(colTextBox.Text, out col))
            {
                if (row >= 0 && row < prices.GetLength(0) && col >= 0 && col < prices.GetLength(1))
                {
                    decimal selectedPrice = prices[row, col];
                    priceLabel.Text = selectedPrice.ToString("c"); 
                }
                else
                {
                    MessageBox.Show("請輸入正確的列(0-5)或欄(0-3)範圍。");
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的整數數字。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
