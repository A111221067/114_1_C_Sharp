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

namespace South_America
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getCountriesButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;

            try 
            {
                // 開啟包含南美洲國家名稱的文字檔。
                inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_1_C_sharp\114_11_19\Countries_Chinese.txt");
                // 清空清單框，以防重複添加國家名稱。
                countriesListBox.Items.Clear();
                // 讀取檔案中的每一行，直到檔案結尾。
                while (!inputFile.EndOfStream)
                {
                    string country = inputFile.ReadLine();
                    countriesListBox.Items.Add(country);
                }
                // 關閉檔案。
                inputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息，如果檔案無法開啟或讀取。
                MessageBox.Show("發生錯誤: " + ex.Message);
            }
            // 這裡是取得國家按鈕的點擊事件處理程式。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        private void countriesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
