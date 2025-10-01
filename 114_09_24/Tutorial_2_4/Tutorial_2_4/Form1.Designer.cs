namespace Tutorial_2_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.germanPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("新細明體", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(154, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "點選國旗會出現國家名稱";
            // 
            // countryLabel
            // 
            this.countryLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countryLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.countryLabel.Location = new System.Drawing.Point(151, 260);
            this.countryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(320, 80);
            this.countryLabel.TabIndex = 1;
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // germanPictureBox
            // 
            this.germanPictureBox.Image = global::Tutorial_2_4.Properties.Resources.Germany;
            this.germanPictureBox.Location = new System.Drawing.Point(428, 129);
            this.germanPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.germanPictureBox.Name = "germanPictureBox";
            this.germanPictureBox.Size = new System.Drawing.Size(131, 87);
            this.germanPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanPictureBox.TabIndex = 4;
            this.germanPictureBox.TabStop = false;
            this.germanPictureBox.Click += new System.EventHandler(this.germanPictureBox_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = global::Tutorial_2_4.Properties.Resources.France;
            this.francePictureBox.Location = new System.Drawing.Point(237, 129);
            this.francePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(129, 87);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 3;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = global::Tutorial_2_4.Properties.Resources.Finland;
            this.finlandPictureBox.Location = new System.Drawing.Point(47, 129);
            this.finlandPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(131, 87);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox.TabIndex = 2;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 398);
            this.Controls.Add(this.germanPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanPictureBox;
    }
}

