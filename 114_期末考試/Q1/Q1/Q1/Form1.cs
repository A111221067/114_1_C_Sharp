using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Q1
{
    public partial class Form1 : Form
    {
        private enum Choice { None = 0, Stone = 1, Paper = 2, Scissor = 3 }
        private readonly Random rnd = new Random();
        private int playerWins = 0;
        private int computerWins = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化顯示
            resultLabel.Text = "請選擇出拳！";
            // 強制設定 PictureBox 縮放模式確保圖檔顯示完整
            computerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            playerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void PlayRound(Choice playerSel)
        {
            Choice computerSel = (Choice)rnd.Next(1, 4);

            // 1. 顯示玩家圖片 (假設檔案在 bin/Debug 下)
            UpdateImage(playerPictureBox, GetFileName(playerSel, "player"));

            // 2. 顯示電腦圖片
            UpdateImage(computerPictureBox, GetFileName(computerSel, "computer"));

            // 3. 判定勝負
            if (playerSel == computerSel)
            {
                resultLabel.Text = "平手！";
                resultLabel.ForeColor = Color.Black;
            }
            else if ((playerSel == Choice.Stone && computerSel == Choice.Scissor) ||
                     (playerSel == Choice.Scissor && computerSel == Choice.Paper) ||
                     (playerSel == Choice.Paper && computerSel == Choice.Stone))
            {
                playerWins++;
                resultLabel.Text = "🎉 玩家贏了！";
                resultLabel.ForeColor = Color.Red;
            }
            else
            {
                computerWins++;
                resultLabel.Text = "💻 電腦贏了！";
                resultLabel.ForeColor = Color.Blue;
            }

            // 4. 更新分數標籤
            playerScoreLabel.Text = $"玩家：{playerWins}";
            computerScoreLabel.Text = $"電腦：{computerWins}";
        }

        private string GetFileName(Choice c, string role)
        {
            string type = c.ToString().ToLower(); // 會得到 "stone", "paper", "scissor"
            return $"{type}_{role}.png";
        }

        private void UpdateImage(PictureBox pb, string fileName)
        {
            // 獲取執行檔所在的資料夾 (例如 bin/Debug/net8.0-windows/)
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string fullPath = Path.Combine(baseDir, fileName);

            // 如果當前目錄找不到，嘗試去上一層 (bin/Debug/) 找
            if (!File.Exists(fullPath))
            {
                string parentDir = Directory.GetParent(baseDir)?.Parent?.FullName;
                if (parentDir != null)
                {
                    fullPath = Path.Combine(parentDir, fileName);
                }
            }

            if (File.Exists(fullPath))
            {
                pb.Image?.Dispose();
                // 使用 FileStream 讀取可以避免檔案被程式鎖住，導致無法重新編譯
                using (FileStream fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                {
                    pb.Image = Image.FromStream(fs);
                }
            }
            else
            {
                // 除錯用：如果還是找不到，彈出訊息告訴你程式在找哪裡
                MessageBox.Show($"找不到圖片：{fileName}\n嘗試路徑：{fullPath}");
            }
        }

        // 按鈕點擊事件
        private void stoneButton_Click(object sender, EventArgs e) => PlayRound(Choice.Stone);
        private void paperButton_Click(object sender, EventArgs e) => PlayRound(Choice.Paper);
        private void scissorButton_Click(object sender, EventArgs e) => PlayRound(Choice.Scissor);

        private void exitButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"遊戲統計：\n玩家勝：{playerWins}\n電腦勝：{computerWins}", "結束統計");
            this.Close();
        }
    }
}