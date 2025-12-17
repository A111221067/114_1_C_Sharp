using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if (cardListBox.SelectedIndex != -1)
            {
                showSelectedCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("請先選擇一張卡片");
            }
        }


        private void showSelectedCard(string cardName)
        {
            switch (cardName)
            {
                case "黑桃A":
                    break;
                case "紅心10":
                    break;
                case "梅花K":
                    break;
                default:
                    MessageBox.Show("未知的卡片選擇");
                    break;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
