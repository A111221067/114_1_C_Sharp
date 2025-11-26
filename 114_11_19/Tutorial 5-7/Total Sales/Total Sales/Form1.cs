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
                inputFile = File.OpenText("Sales.txt");
                listBox1.Items.Clear();

                while (!inputFile.EndOfStream)
                {
                    if (decimal.TryParse(line = inputFile.ReadLine(), out currentSales))
                    {
                        listBox1.Items.Add(line);
                        currentSales = decimal.Parse(inputFile.ReadLine());
                        total += currentSales;
                    }
                    else
                    {
                        MessageBox.Show("資料格式錯誤: " + line);
                        break;
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


        private void exitButton_Click(object sender, EventArgs e)
        {
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
