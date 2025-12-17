namespace Comprehensive_Practice_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // New controls
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.Label lblQuiz2;
        private System.Windows.Forms.Label lblQuiz3;

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz3;

        private System.Windows.Forms.Button btnShowHighest;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Label lblResult;

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
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.lblQuiz2 = new System.Windows.Forms.Label();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.lblQuiz3 = new System.Windows.Forms.Label();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.btnShowHighest = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(579, 86);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(153, 57);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "姓";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(291, 85);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(170, 57);
            this.txtLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(132, 85);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(153, 57);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "名";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(738, 86);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 57);
            this.txtFirstName.TabIndex = 3;
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz1.Location = new System.Drawing.Point(42, 224);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(151, 57);
            this.lblQuiz1.TabIndex = 4;
            this.lblQuiz1.Text = "小考1";
            this.lblQuiz1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz1.Location = new System.Drawing.Point(233, 224);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(135, 57);
            this.txtQuiz1.TabIndex = 5;
            // 
            // lblQuiz2
            // 
            this.lblQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz2.Location = new System.Drawing.Point(42, 310);
            this.lblQuiz2.Name = "lblQuiz2";
            this.lblQuiz2.Size = new System.Drawing.Size(151, 57);
            this.lblQuiz2.TabIndex = 6;
            this.lblQuiz2.Text = "小考2";
            this.lblQuiz2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz2.Location = new System.Drawing.Point(233, 310);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(135, 57);
            this.txtQuiz2.TabIndex = 7;
            // 
            // lblQuiz3
            // 
            this.lblQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz3.Location = new System.Drawing.Point(42, 398);
            this.lblQuiz3.Name = "lblQuiz3";
            this.lblQuiz3.Size = new System.Drawing.Size(151, 57);
            this.lblQuiz3.TabIndex = 8;
            this.lblQuiz3.Text = "小考3";
            this.lblQuiz3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuiz3.Location = new System.Drawing.Point(233, 398);
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(135, 57);
            this.txtQuiz3.TabIndex = 9;
            // 
            // btnShowHighest
            // 
            this.btnShowHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowHighest.Location = new System.Drawing.Point(154, 557);
            this.btnShowHighest.Name = "btnShowHighest";
            this.btnShowHighest.Size = new System.Drawing.Size(288, 69);
            this.btnShowHighest.TabIndex = 10;
            this.btnShowHighest.Text = "顯示最高分";
            this.btnShowHighest.Click += new System.EventHandler(this.btnShowHighest_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(590, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(288, 69);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(535, 351);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(520, 65);
            this.lblResult.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 685);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblQuiz1);
            this.Controls.Add(this.txtQuiz1);
            this.Controls.Add(this.lblQuiz2);
            this.Controls.Add(this.txtQuiz2);
            this.Controls.Add(this.lblQuiz3);
            this.Controls.Add(this.txtQuiz3);
            this.Controls.Add(this.btnShowHighest);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

