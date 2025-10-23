using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        // 定義硬幣面額常數（單位：分）
        const decimal FIVE_CENTS = 5.0m;      // 5分硬幣
        const decimal TEN_CENTS = 10.0m;      // 10分硬幣
        const decimal TWENTY_FIVE_CENTS = 25.0m; // 25分硬幣
        const decimal FIFTY_CENTS = 50.0m;    // 50分硬幣

        // 儲存目前累計的金額（單位：分）
        private decimal total;

        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 點擊5分硬幣圖片時觸發的事件
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加5分到總金額
            total += FIVE_CENTS;
            // 顯示目前累計金額
            totalLabel.Text = total.ToString();
        }

        // 點擊10分硬幣圖片時觸發的事件
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加10分到總金額
            total += TEN_CENTS;
            // 顯示目前累計金額
            totalLabel.Text = total.ToString();
        }

        // 點擊25分硬幣圖片時觸發的事件
        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加25分到總金額
            total += TWENTY_FIVE_CENTS;
            // 顯示目前累計金額
            totalLabel.Text = total.ToString();
        }

        // 點擊50分硬幣圖片時觸發的事件
        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            // 累加50分到總金額
            total += FIFTY_CENTS;
            // 顯示目前累計金額
            totalLabel.Text = total.ToString();
        }

        // 點擊「離開」按鈕時觸發的事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉視窗
            this.Close();
        }
    }
}
