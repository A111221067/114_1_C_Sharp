namespace Tutorial2_3
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
            this.translationLabel = new System.Windows.Forms.Label();
            this.ItalianButton = new System.Windows.Forms.Button();
            this.SpanishButton = new System.Windows.Forms.Button();
            this.GermanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇一個語言，我會說早安";
            // 
            // translationLabel
            // 
            this.translationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.translationLabel.Font = new System.Drawing.Font("標楷體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.translationLabel.Location = new System.Drawing.Point(123, 205);
            this.translationLabel.Name = "translationLabel";
            this.translationLabel.Size = new System.Drawing.Size(524, 98);
            this.translationLabel.TabIndex = 1;
            this.translationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.translationLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ItalianButton
            // 
            this.ItalianButton.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ItalianButton.Location = new System.Drawing.Point(52, 351);
            this.ItalianButton.Name = "ItalianButton";
            this.ItalianButton.Size = new System.Drawing.Size(173, 47);
            this.ItalianButton.TabIndex = 2;
            this.ItalianButton.Text = "義大利文";
            this.ItalianButton.UseVisualStyleBackColor = true;
            this.ItalianButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpanishButton
            // 
            this.SpanishButton.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SpanishButton.Location = new System.Drawing.Point(290, 351);
            this.SpanishButton.Name = "SpanishButton";
            this.SpanishButton.Size = new System.Drawing.Size(173, 47);
            this.SpanishButton.TabIndex = 3;
            this.SpanishButton.Text = "西班牙文";
            this.SpanishButton.UseVisualStyleBackColor = true;
            this.SpanishButton.Click += new System.EventHandler(this.SpanishButton_Click);
            // 
            // GermanButton
            // 
            this.GermanButton.Font = new System.Drawing.Font("標楷體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GermanButton.Location = new System.Drawing.Point(535, 351);
            this.GermanButton.Name = "GermanButton";
            this.GermanButton.Size = new System.Drawing.Size(173, 47);
            this.GermanButton.TabIndex = 4;
            this.GermanButton.Text = "德文";
            this.GermanButton.UseVisualStyleBackColor = true;
            this.GermanButton.Click += new System.EventHandler(this.GermanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GermanButton);
            this.Controls.Add(this.SpanishButton);
            this.Controls.Add(this.ItalianButton);
            this.Controls.Add(this.translationLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "語言翻譯器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label translationLabel;
        private System.Windows.Forms.Button ItalianButton;
        private System.Windows.Forms.Button SpanishButton;
        private System.Windows.Forms.Button GermanButton;
    }
}

