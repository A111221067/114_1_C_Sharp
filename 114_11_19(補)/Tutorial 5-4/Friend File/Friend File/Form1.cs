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
        // 將 count 欄位移除 readonly 修飾詞，讓它可以在方法中遞增。
        private int count = 1; // 成員變數，計數朋友的數量
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            // int count = 1; //區域變數，每次按鈕點擊時重設為1
            StreamWriter outputFile;

            try
            {
                // 以附加模式開啟朋友檔案。
                outputFile = File.AppendText("friends.txt");
                // 寫入朋友的名字。
                outputFile.WriteLine(count + ":" + nameTextBox.Text);
                // 關閉檔案。
                outputFile.Close();
            }
            catch (Exception ex)
            {
                // 顯示錯誤訊息。
                MessageBox.Show(ex.Message);
            }
            nameTextBox.Text = "";
            nameTextBox.Focus();
            count++; // 增加朋友計數
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
