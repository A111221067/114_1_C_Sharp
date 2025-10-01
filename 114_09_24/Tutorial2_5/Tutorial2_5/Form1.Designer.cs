namespace Tutorial2_5
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cardFacePictureBox = new System.Windows.Forms.PictureBox();
            this.cardBackPictureBox = new System.Windows.Forms.PictureBox();
            this.showBackButton = new System.Windows.Forms.Button();
            this.showFaceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cardFacePictureBox
            // 
            this.cardFacePictureBox.Image = global::Tutorial2_5.Properties.Resources.Ace_Hearts;
            this.cardFacePictureBox.Location = new System.Drawing.Point(191, 44);
            this.cardFacePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardFacePictureBox.Name = "cardFacePictureBox";
            this.cardFacePictureBox.Size = new System.Drawing.Size(127, 171);
            this.cardFacePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardFacePictureBox.TabIndex = 1;
            this.cardFacePictureBox.TabStop = false;
            this.cardFacePictureBox.Visible = false;
            // 
            // cardBackPictureBox
            // 
            this.cardBackPictureBox.Image = global::Tutorial2_5.Properties.Resources.Backface_Red;
            this.cardBackPictureBox.Location = new System.Drawing.Point(191, 44);
            this.cardBackPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardBackPictureBox.Name = "cardBackPictureBox";
            this.cardBackPictureBox.Size = new System.Drawing.Size(127, 171);
            this.cardBackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardBackPictureBox.TabIndex = 0;
            this.cardBackPictureBox.TabStop = false;
            this.cardBackPictureBox.Visible = false;
            // 
            // showBackButton
            // 
            this.showBackButton.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showBackButton.Location = new System.Drawing.Point(92, 242);
            this.showBackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showBackButton.Name = "showBackButton";
            this.showBackButton.Size = new System.Drawing.Size(111, 31);
            this.showBackButton.TabIndex = 2;
            this.showBackButton.Text = "背面";
            this.showBackButton.UseVisualStyleBackColor = true;
            this.showBackButton.Click += new System.EventHandler(this.showBackButton_Click);
            // 
            // showFaceButton
            // 
            this.showFaceButton.Font = new System.Drawing.Font("標楷體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showFaceButton.Location = new System.Drawing.Point(311, 242);
            this.showFaceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showFaceButton.Name = "showFaceButton";
            this.showFaceButton.Size = new System.Drawing.Size(115, 31);
            this.showFaceButton.TabIndex = 3;
            this.showFaceButton.Text = "正面";
            this.showFaceButton.UseVisualStyleBackColor = true;
            this.showFaceButton.Click += new System.EventHandler(this.showFaceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 310);
            this.Controls.Add(this.showFaceButton);
            this.Controls.Add(this.showBackButton);
            this.Controls.Add(this.cardFacePictureBox);
            this.Controls.Add(this.cardBackPictureBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "翻轉撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cardFacePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardBackPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cardBackPictureBox;
        private System.Windows.Forms.PictureBox cardFacePictureBox;
        private System.Windows.Forms.Button showBackButton;
        private System.Windows.Forms.Button showFaceButton;
    }
}

