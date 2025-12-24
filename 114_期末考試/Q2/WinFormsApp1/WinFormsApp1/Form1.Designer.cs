using System.Windows.Forms;
using System.Drawing;

namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private GroupBox gbOilLube;
        private CheckBox cbOilChange;
        private CheckBox cbLube;

        private GroupBox gbFlush;
        private CheckBox cbRadiatorFlush;
        private CheckBox cbTransmissionFlush;

        private GroupBox gbMisc;
        private CheckBox cbInspection;
        private CheckBox cbReplaceMuffler;
        private CheckBox cbTireRotation;

        private GroupBox gbPartsLabor;
        private Label lblParts;
        private TextBox txtParts;
        private Label lblHours;
        private TextBox txtHours;

        private GroupBox gbSummary;
        private Label lblServiceAndLabor;
        private TextBox txtServiceAndLabor;
        private Label lblPartsCost;
        private TextBox txtPartsCost;
        private Label lblTax;
        private TextBox txtTax;
        private Label lblTotal;
        private TextBox txtTotal;

        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            gbOilLube = new GroupBox();
            cbOilChange = new CheckBox();
            cbLube = new CheckBox();
            gbFlush = new GroupBox();
            cbRadiatorFlush = new CheckBox();
            cbTransmissionFlush = new CheckBox();
            gbMisc = new GroupBox();
            cbInspection = new CheckBox();
            cbReplaceMuffler = new CheckBox();
            cbTireRotation = new CheckBox();
            gbPartsLabor = new GroupBox();
            lblParts = new Label();
            txtParts = new TextBox();
            lblHours = new Label();
            txtHours = new TextBox();
            gbSummary = new GroupBox();
            lblServiceAndLabor = new Label();
            txtServiceAndLabor = new TextBox();
            lblPartsCost = new Label();
            txtPartsCost = new TextBox();
            lblTax = new Label();
            txtTax = new TextBox();
            lblTotal = new Label();
            txtTotal = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            gbOilLube.SuspendLayout();
            gbFlush.SuspendLayout();
            gbMisc.SuspendLayout();
            gbPartsLabor.SuspendLayout();
            gbSummary.SuspendLayout();
            SuspendLayout();
            // 
            // gbOilLube
            // 
            gbOilLube.Controls.Add(cbOilChange);
            gbOilLube.Controls.Add(cbLube);
            gbOilLube.Location = new Point(12, 12);
            gbOilLube.Name = "gbOilLube";
            gbOilLube.Size = new Size(240, 90);
            gbOilLube.TabIndex = 0;
            gbOilLube.TabStop = false;
            gbOilLube.Text = "機油和潤滑";
            // 
            // cbOilChange
            // 
            cbOilChange.AutoSize = true;
            cbOilChange.Location = new Point(10, 22);
            cbOilChange.Name = "cbOilChange";
            cbOilChange.Size = new Size(190, 27);
            cbOilChange.TabIndex = 0;
            cbOilChange.Text = "更換機油 (NT$780)";
            // 
            // cbLube
            // 
            cbLube.AutoSize = true;
            cbLube.Location = new Point(10, 48);
            cbLube.Name = "cbLube";
            cbLube.Size = new Size(190, 27);
            cbLube.TabIndex = 1;
            cbLube.Text = "潤滑保養 (NT$540)";
            // 
            // gbFlush
            // 
            gbFlush.Controls.Add(cbRadiatorFlush);
            gbFlush.Controls.Add(cbTransmissionFlush);
            gbFlush.Location = new Point(12, 108);
            gbFlush.Name = "gbFlush";
            gbFlush.Size = new Size(240, 90);
            gbFlush.TabIndex = 1;
            gbFlush.TabStop = false;
            gbFlush.Text = "清洗服務";
            // 
            // cbRadiatorFlush
            // 
            cbRadiatorFlush.AutoSize = true;
            cbRadiatorFlush.Location = new Point(10, 22);
            cbRadiatorFlush.Name = "cbRadiatorFlush";
            cbRadiatorFlush.Size = new Size(190, 27);
            cbRadiatorFlush.TabIndex = 0;
            cbRadiatorFlush.Text = "水箱清洗 (NT$900)";
            // 
            // cbTransmissionFlush
            // 
            cbTransmissionFlush.AutoSize = true;
            cbTransmissionFlush.Location = new Point(10, 48);
            cbTransmissionFlush.Name = "cbTransmissionFlush";
            cbTransmissionFlush.Size = new Size(222, 27);
            cbTransmissionFlush.TabIndex = 1;
            cbTransmissionFlush.Text = "變速箱清洗 (NT$2,400)";
            // 
            // gbMisc
            // 
            gbMisc.Controls.Add(cbInspection);
            gbMisc.Controls.Add(cbReplaceMuffler);
            gbMisc.Controls.Add(cbTireRotation);
            gbMisc.Location = new Point(12, 204);
            gbMisc.Name = "gbMisc";
            gbMisc.Size = new Size(240, 120);
            gbMisc.TabIndex = 2;
            gbMisc.TabStop = false;
            gbMisc.Text = "其他服務";
            // 
            // cbInspection
            // 
            cbInspection.AutoSize = true;
            cbInspection.Location = new Point(10, 22);
            cbInspection.Name = "cbInspection";
            cbInspection.Size = new Size(154, 27);
            cbInspection.TabIndex = 0;
            cbInspection.Text = "檢驗 (NT$450)";
            // 
            // cbReplaceMuffler
            // 
            cbReplaceMuffler.AutoSize = true;
            cbReplaceMuffler.Location = new Point(10, 48);
            cbReplaceMuffler.Name = "cbReplaceMuffler";
            cbReplaceMuffler.Size = new Size(222, 27);
            cbReplaceMuffler.TabIndex = 1;
            cbReplaceMuffler.Text = "更換消音器 (NT$3,000)";
            // 
            // cbTireRotation
            // 
            cbTireRotation.AutoSize = true;
            cbTireRotation.Location = new Point(10, 74);
            cbTireRotation.Name = "cbTireRotation";
            cbTireRotation.Size = new Size(190, 27);
            cbTireRotation.TabIndex = 2;
            cbTireRotation.Text = "輪胎換位 (NT$600)";
            // 
            // gbPartsLabor
            // 
            gbPartsLabor.Controls.Add(lblParts);
            gbPartsLabor.Controls.Add(txtParts);
            gbPartsLabor.Controls.Add(lblHours);
            gbPartsLabor.Controls.Add(txtHours);
            gbPartsLabor.Location = new Point(268, 12);
            gbPartsLabor.Name = "gbPartsLabor";
            gbPartsLabor.Size = new Size(240, 140);
            gbPartsLabor.TabIndex = 3;
            gbPartsLabor.TabStop = false;
            gbPartsLabor.Text = "零件和工時";
            // 
            // lblParts
            // 
            lblParts.AutoSize = true;
            lblParts.Location = new Point(10, 28);
            lblParts.Name = "lblParts";
            lblParts.Size = new Size(98, 23);
            lblParts.TabIndex = 0;
            lblParts.Text = "零件 (NT$)";
            // 
            // txtParts
            // 
            txtParts.Location = new Point(114, 22);
            txtParts.Name = "txtParts";
            txtParts.Size = new Size(120, 30);
            txtParts.TabIndex = 1;
            // 
            // lblHours
            // 
            lblHours.AutoSize = true;
            lblHours.Location = new Point(10, 64);
            lblHours.Name = "lblHours";
            lblHours.Size = new Size(117, 23);
            lblHours.TabIndex = 2;
            lblHours.Text = "工時數 (小時)";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(144, 60);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(90, 30);
            txtHours.TabIndex = 3;
            // 
            // gbSummary
            // 
            gbSummary.Controls.Add(lblServiceAndLabor);
            gbSummary.Controls.Add(txtServiceAndLabor);
            gbSummary.Controls.Add(lblPartsCost);
            gbSummary.Controls.Add(txtPartsCost);
            gbSummary.Controls.Add(lblTax);
            gbSummary.Controls.Add(txtTax);
            gbSummary.Controls.Add(lblTotal);
            gbSummary.Controls.Add(txtTotal);
            gbSummary.Location = new Point(268, 160);
            gbSummary.Name = "gbSummary";
            gbSummary.Size = new Size(240, 164);
            gbSummary.TabIndex = 4;
            gbSummary.TabStop = false;
            gbSummary.Text = "費用摘要";
            // 
            // lblServiceAndLabor
            // 
            lblServiceAndLabor.AutoSize = true;
            lblServiceAndLabor.Location = new Point(0, 37);
            lblServiceAndLabor.Name = "lblServiceAndLabor";
            lblServiceAndLabor.Size = new Size(100, 23);
            lblServiceAndLabor.TabIndex = 0;
            lblServiceAndLabor.Text = "服務與工資";
            // 
            // txtServiceAndLabor
            // 
            txtServiceAndLabor.Location = new Point(110, 24);
            txtServiceAndLabor.Name = "txtServiceAndLabor";
            txtServiceAndLabor.ReadOnly = true;
            txtServiceAndLabor.Size = new Size(110, 30);
            txtServiceAndLabor.TabIndex = 1;
            // 
            // lblPartsCost
            // 
            lblPartsCost.AutoSize = true;
            lblPartsCost.Location = new Point(10, 60);
            lblPartsCost.Name = "lblPartsCost";
            lblPartsCost.Size = new Size(46, 23);
            lblPartsCost.TabIndex = 2;
            lblPartsCost.Text = "零件";
            // 
            // txtPartsCost
            // 
            txtPartsCost.Location = new Point(110, 56);
            txtPartsCost.Name = "txtPartsCost";
            txtPartsCost.ReadOnly = true;
            txtPartsCost.Size = new Size(110, 30);
            txtPartsCost.TabIndex = 3;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(10, 92);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(99, 23);
            lblTax.TabIndex = 4;
            lblTax.Text = "稅金 (零件)";
            // 
            // txtTax
            // 
            txtTax.Location = new Point(110, 120);
            txtTax.Name = "txtTax";
            txtTax.ReadOnly = true;
            txtTax.Size = new Size(110, 30);
            txtTax.TabIndex = 5;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(10, 124);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(64, 23);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "總費用";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(110, 120);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(110, 30);
            txtTotal.TabIndex = 7;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(41, 390);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(110, 28);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "計算總額";
            btnCalculate.Click += calculateButton_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(214, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 28);
            btnClear.TabIndex = 6;
            btnClear.Text = "清除";
            btnClear.Click += clearButton_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(358, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(110, 28);
            btnExit.TabIndex = 7;
            btnExit.Text = "離開";
            btnExit.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 476);
            Controls.Add(gbOilLube);
            Controls.Add(gbFlush);
            Controls.Add(gbMisc);
            Controls.Add(gbPartsLabor);
            Controls.Add(gbSummary);
            Controls.Add(btnCalculate);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "汽車維修服務";
            gbOilLube.ResumeLayout(false);
            gbOilLube.PerformLayout();
            gbFlush.ResumeLayout(false);
            gbFlush.PerformLayout();
            gbMisc.ResumeLayout(false);
            gbMisc.PerformLayout();
            gbPartsLabor.ResumeLayout(false);
            gbPartsLabor.PerformLayout();
            gbSummary.ResumeLayout(false);
            gbSummary.PerformLayout();
            ResumeLayout(false);
        }
    }
}