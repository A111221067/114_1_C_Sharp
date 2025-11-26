using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;
            decimal total = 0m;
            decimal currentSales = 0m;
            string line;

            try
            {
                inputFile = File.OpenText(@"C:\Users\Nick\OneDrive\桌面\114_1_C_Sharp\114_11_26\Sales.txt");
                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    line = inputFile.ReadLine();

                    string[] parts = line.Split(new char[] { ',' },StringSplitOptions.RemoveEmptyEntries);
 
                   
                    if (parts.Length>=2)
                    {
                        string month = parts[0];
                        string saleValue = parts[1];

                    }
                    else
                    {
                        MessageBox.Show("Invalid data format: " + line);
                    }
                }
                inputFile.Close();
                totalLabel.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }

        /// <summary>
        /// exitButton_Click 事件處理程序：
        /// 當使用者點擊「結束」按鈕時觸發此方法。
        /// 負責關閉此表單視窗，結束應用程式執行。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，終止應用程式
            this.Close();
        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
