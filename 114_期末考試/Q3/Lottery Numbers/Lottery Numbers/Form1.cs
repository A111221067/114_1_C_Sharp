using System;
using System.IO;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        // 使用陣列儲存資料，符合技術要求
        int[] userNumbers = new int[5];
        int[] winningNumbers = new int[5];
        bool hasUserNumbers = false;
        bool hasWinningNumbers = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 「產生號碼」按鈕事件
        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < userNumbers.Length; i++)
            {
                int temp = rand.Next(1, 50);
                bool isDuplicate = false;

                // 實作不重複亂數演算法
                for (int j = 0; j < i; j++)
                {
                    if (userNumbers[j] == temp)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (isDuplicate) i--;
                else userNumbers[i] = temp;
            }

            // 更新介面 Label 顯示
            firstLabel.Text = userNumbers[0].ToString();
            secondLabel.Text = userNumbers[1].ToString();
            thirdLabel.Text = userNumbers[2].ToString();
            fourthLabel.Text = userNumbers[3].ToString();
            fifthLabel.Text = userNumbers[4].ToString();

            hasUserNumbers = true;
            CheckAndMatch();
        }

        // 「開獎號碼」按鈕事件 (檔案讀取)
        private void generateButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "文字檔案|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        listBox1.Items.Clear(); // 修正處：確保使用 ListBox
                        listBox1.Items.Add("本期開獎號碼：");

                        for (int i = 0; i < 5; i++)
                        {
                            string line = sr.ReadLine();
                            if (line == null) throw new Exception("檔案行數不足！");

                            int num = int.Parse(line);
                            if (num < 1 || num > 49) throw new Exception("數字超出範圍(1-49)！");

                            winningNumbers[i] = num;
                            listBox1.Items.Add($"第{i + 1}個號碼：{num}");
                        }
                        hasWinningNumbers = true;
                        CheckAndMatch();
                    }
                }
                catch (Exception ex)
                {
                    // 具備完整的錯誤處理機制
                    MessageBox.Show("讀取失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 核心比對方法
        private void CheckAndMatch()
        {
            if (!hasUserNumbers || !hasWinningNumbers) return;

            int matchCount = 0;
            // 使用基本語法進行比對判定
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (userNumbers[i] == winningNumbers[j])
                    {
                        matchCount++;
                        break;
                    }
                }
            }

            // 顯示結果
            matchResultLabel.Text = $"中{matchCount}個號碼";

            // 根據中獎數量判定獎項等級
            if (matchCount == 5) prizeLabel.Text = "🤑 頭獎！";
            else if (matchCount == 4) prizeLabel.Text = "😮 二獎！";
            else if (matchCount == 3) prizeLabel.Text = "😊 三獎！";
            else prizeLabel.Text = "😞 沒中獎";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}