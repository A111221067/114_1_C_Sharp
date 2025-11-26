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

namespace Friend_File
{
    public partial class Form1 : Form
    {
        private int count = 1; 
                              
        private SaveFileDialog saveFile = new SaveFileDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;

        

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                outputFile = File.AppendText(saveFile.FileName);
                outputFile.WriteLine(count + ":" + nameTextBox.Text);
                outputFile.Close();
                count++; 
            }
            else
            {
                MessageBox.Show("未選擇檔案，無法寫入資料。");
            }

            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++;
        }
           

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
