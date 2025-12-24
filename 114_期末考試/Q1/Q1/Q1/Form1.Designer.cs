namespace Q1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Button stoneButton;
        private System.Windows.Forms.Button paperButton;
        private System.Windows.Forms.Button scissorButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerScoreLabel;
        private System.Windows.Forms.Label computerScoreLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            computerPictureBox = new PictureBox();
            playerPictureBox = new PictureBox();
            stoneButton = new Button();
            paperButton = new Button();
            scissorButton = new Button();
            exitButton = new Button();
            resultLabel = new Label();
            computerLabel = new Label();
            playerLabel = new Label();
            playerScoreLabel = new Label();
            computerScoreLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // computerPictureBox
            // 
            computerPictureBox.BackColor = Color.Beige;
            computerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            computerPictureBox.Location = new Point(60, 50);
            computerPictureBox.Name = "computerPictureBox";
            computerPictureBox.Size = new Size(200, 120);
            computerPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            computerPictureBox.TabIndex = 0;
            computerPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            playerPictureBox.BackColor = Color.Beige;
            playerPictureBox.BorderStyle = BorderStyle.FixedSingle;
            playerPictureBox.Location = new Point(420, 50);
            playerPictureBox.Name = "playerPictureBox";
            playerPictureBox.Size = new Size(200, 120);
            playerPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            playerPictureBox.TabIndex = 1;
            playerPictureBox.TabStop = false;
            // 
            // stoneButton
            // 
            stoneButton.Font = new Font("微軟正黑體", 14F);
            stoneButton.Location = new Point(60, 270);
            stoneButton.Name = "stoneButton";
            stoneButton.Size = new Size(140, 60);
            stoneButton.TabIndex = 2;
            stoneButton.Text = "石頭";
            stoneButton.UseVisualStyleBackColor = true;
            stoneButton.Click += stoneButton_Click;
            // 
            // paperButton
            // 
            paperButton.Font = new Font("微軟正黑體", 14F);
            paperButton.Location = new Point(260, 270);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(140, 60);
            paperButton.TabIndex = 3;
            paperButton.Text = "布";
            paperButton.UseVisualStyleBackColor = true;
            paperButton.Click += paperButton_Click;
            // 
            // scissorButton
            // 
            scissorButton.Font = new Font("微軟正黑體", 14F);
            scissorButton.Location = new Point(480, 270);
            scissorButton.Name = "scissorButton";
            scissorButton.Size = new Size(140, 60);
            scissorButton.TabIndex = 4;
            scissorButton.Text = "剪刀";
            scissorButton.UseVisualStyleBackColor = true;
            scissorButton.Click += scissorButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("微軟正黑體", 12F);
            exitButton.Location = new Point(260, 350);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 50);
            exitButton.TabIndex = 5;
            exitButton.Text = "結束遊戲";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("微軟正黑體", 16F);
            resultLabel.Location = new Point(200, 190);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(360, 40);
            resultLabel.TabIndex = 6;
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // computerLabel
            // 
            computerLabel.AutoSize = true;
            computerLabel.Font = new Font("微軟正黑體", 12F);
            computerLabel.Location = new Point(60, 20);
            computerLabel.Name = "computerLabel";
            computerLabel.Size = new Size(85, 30);
            computerLabel.TabIndex = 7;
            computerLabel.Text = "電腦出";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("微軟正黑體", 12F);
            playerLabel.Location = new Point(420, 20);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(85, 30);
            playerLabel.TabIndex = 8;
            playerLabel.Text = "玩家出";
            // 
            // playerScoreLabel
            // 
            playerScoreLabel.Font = new Font("微軟正黑體", 10F);
            playerScoreLabel.Location = new Point(420, 180);
            playerScoreLabel.Name = "playerScoreLabel";
            playerScoreLabel.Size = new Size(200, 20);
            playerScoreLabel.TabIndex = 9;
            playerScoreLabel.Text = "玩家：0";
            playerScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // computerScoreLabel
            // 
            computerScoreLabel.Font = new Font("微軟正黑體", 10F);
            computerScoreLabel.Location = new Point(60, 180);
            computerScoreLabel.Name = "computerScoreLabel";
            computerScoreLabel.Size = new Size(200, 20);
            computerScoreLabel.TabIndex = 10;
            computerScoreLabel.Text = "電腦：0";
            computerScoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            ClientSize = new Size(700, 430);
            Controls.Add(computerScoreLabel);
            Controls.Add(playerScoreLabel);
            Controls.Add(playerLabel);
            Controls.Add(computerLabel);
            Controls.Add(resultLabel);
            Controls.Add(exitButton);
            Controls.Add(scissorButton);
            Controls.Add(paperButton);
            Controls.Add(stoneButton);
            Controls.Add(playerPictureBox);
            Controls.Add(computerPictureBox);
            Name = "Form1";
            Text = "猜拳遊戲";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)computerPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}