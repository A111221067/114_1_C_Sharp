namespace Coin_Toss
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.headsLabelText = new System.Windows.Forms.Label();
            this.headsCountLabel = new System.Windows.Forms.Label();
            this.tailsLabelText = new System.Windows.Forms.Label();
            this.tailsCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Coin_Toss.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(33, 11);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 157);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Coin_Toss.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(33, 11);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 157);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tossButton
            // 
            this.tossButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tossButton.Location = new System.Drawing.Point(33, 199);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(118, 63);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "擲硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(189, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 68);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headsLabelText
            // 
            this.headsLabelText.AutoSize = true;
            this.headsLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsLabelText.Location = new System.Drawing.Point(220, 18);
            this.headsLabelText.Name = "headsLabelText";
            this.headsLabelText.Size = new System.Drawing.Size(109, 29);
            this.headsLabelText.TabIndex = 4;
            this.headsLabelText.Text = "正面次數";
            // 
            // headsCountLabel
            // 
            this.headsCountLabel.AutoSize = true;
            this.headsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsCountLabel.Location = new System.Drawing.Point(220, 51);
            this.headsCountLabel.Name = "headsCountLabel";
            this.headsCountLabel.Size = new System.Drawing.Size(26, 29);
            this.headsCountLabel.TabIndex = 5;
            this.headsCountLabel.Text = "0";
            // 
            // tailsLabelText
            // 
            this.tailsLabelText.AutoSize = true;
            this.tailsLabelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsLabelText.Location = new System.Drawing.Point(220, 88);
            this.tailsLabelText.Name = "tailsLabelText";
            this.tailsLabelText.Size = new System.Drawing.Size(109, 29);
            this.tailsLabelText.TabIndex = 6;
            this.tailsLabelText.Text = "反面次數";
            // 
            // tailsCountLabel
            // 
            this.tailsCountLabel.AutoSize = true;
            this.tailsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tailsCountLabel.Location = new System.Drawing.Point(220, 120);
            this.tailsCountLabel.Name = "tailsCountLabel";
            this.tailsCountLabel.Size = new System.Drawing.Size(26, 29);
            this.tailsCountLabel.TabIndex = 7;
            this.tailsCountLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 290);
            this.Controls.Add(this.tailsCountLabel);
            this.Controls.Add(this.tailsLabelText);
            this.Controls.Add(this.headsCountLabel);
            this.Controls.Add(this.headsLabelText);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.tailsPictureBox);
            this.Name = "Form1";
            this.Text = "擲硬幣";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label headsLabelText;
        private System.Windows.Forms.Label headsCountLabel;
        private System.Windows.Forms.Label tailsLabelText;
        private System.Windows.Forms.Label tailsCountLabel;
    }
}
