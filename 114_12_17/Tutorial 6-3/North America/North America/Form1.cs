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

namespace North_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetFileName(out string fileName)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileName = openFile.FileName;
            }
            else
            {
                fileName = "";
            }
        }

        private void GetCountries(string fileName)
        {
            countriesListBox.Items.Clear();

            if (fileName == "")
            {
                MessageBox.Show("未選取檔案。");
                return;
            }

            StreamReader inputFile = File.OpenText(fileName);

            while (!inputFile.EndOfStream)
            {
                countriesListBox.Items.Add(inputFile.ReadLine());
            }

            inputFile.Close();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            string fileName = "";
            GetFileName(out fileName);
            GetCountries(fileName);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
