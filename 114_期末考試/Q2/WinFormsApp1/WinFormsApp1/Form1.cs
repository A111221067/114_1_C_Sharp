using System.Globalization;
using System.Text;

//csharp WinFormsApp1\Form1.cs
using System;
using System.IO;
//using System.Text;
//using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal OIL_CHANGE = 780m;
        private const decimal LUBE = 540m;
        private const decimal RADIATOR_FLUSH = 900m;
        private const decimal TRANSMISSION_FLUSH = 2400m;
        private const decimal INSPECTION = 450m;
        private const decimal MUFFLER = 3000m;
        private const decimal TIRE_ROTATION = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        private bool isCalculated = false;

        public Form1()
        {
            InitializeComponent();
            // 初始化狀態
            ClearFees();
        }

        // 計算不同類別費用
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (cbOilChange.Checked) total += OIL_CHANGE;
            if (cbLube.Checked) total += LUBE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (cbRadiatorFlush.Checked) total += RADIATOR_FLUSH;
            if (cbTransmissionFlush.Checked) total += TRANSMISSION_FLUSH;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (cbInspection.Checked) total += INSPECTION;
            if (cbReplaceMuffler.Checked) total += MUFFLER;
            if (cbTireRotation.Checked) total += TIRE_ROTATION;
            return total;
        }

        private decimal OtherCharges(out decimal partsCost, out decimal laborCost)
        {
            // 解析零件與工時
            partsCost = 0m;
            laborCost = 0m;

            if (!string.IsNullOrWhiteSpace(txtParts.Text))
            {
                if (!decimal.TryParse(txtParts.Text, out partsCost) || partsCost < 0m)
                {
                    MessageBox.Show("零件費用請輸入非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    partsCost = 0m;
                    return 0m;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtHours.Text))
            {
                if (!decimal.TryParse(txtHours.Text, out decimal hours) || hours < 0m)
                {
                    MessageBox.Show("工時請輸入非負數字。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHours.Focus();
                    return 0m;
                }
                laborCost = hours * LABOR_RATE_PER_HOUR;
            }

            return laborCost;
        }

        private decimal TaxCharges(decimal partsCost)
        {
            return Math.Round(partsCost * PARTS_TAX_RATE, 0);
        }

        private decimal TotalCharges(out decimal serviceAndLabor, out decimal partsCost, out decimal tax)
        {
            decimal oilLube = OilLubeCharges();
            decimal flushes = FlushCharges();
            decimal misc = MiscCharges();

            decimal serviceFees = oilLube + flushes + misc;

            decimal laborCost = OtherCharges(out partsCost, out decimal labor);
            serviceAndLabor = serviceFees + laborCost;

            tax = TaxCharges(partsCost);

            decimal total = serviceAndLabor + partsCost + tax;
            return total;
        }

        // 事件處理
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算並更新介面
            decimal serviceAndLabor, partsCost, tax;
            decimal total = TotalCharges(out serviceAndLabor, out partsCost, out tax);

            var ci = new CultureInfo("zh-TW");

            txtServiceAndLabor.Text = serviceAndLabor.ToString("C0", ci);
            txtPartsCost.Text = partsCost.ToString("C0", ci);
            txtTax.Text = tax.ToString("C0", ci);
            txtTotal.Text = total.ToString("C0", ci);

            isCalculated = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
            isCalculated = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Clear helper methods
        private void ClearOilLube()
        {
            cbOilChange.Checked = false;
            cbLube.Checked = false;
        }

        private void ClearFlushes()
        {
            cbRadiatorFlush.Checked = false;
            cbTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            cbInspection.Checked = false;
            cbReplaceMuffler.Checked = false;
            cbTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            txtParts.Text = string.Empty;
            txtHours.Text = string.Empty;
        }

        private void ClearFees()
        {
            txtServiceAndLabor.Text = string.Empty;
            txtPartsCost.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        // 檔案輸出
        private void SaveServiceDetailsToFile()
        {
            if (!isCalculated)
            {
                MessageBox.Show("尚未計算任何費用，無內容可儲存。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "文字檔 (*.txt)|*.txt";
                sfd.FileName = "維修明細_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var ci = new CultureInfo("zh-TW");
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("=== 汽車維修服務明細 ===");
                    sb.AppendLine("產生日期: " + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
                    sb.AppendLine();

                    sb.AppendLine("服務項目：");
                    if (cbOilChange.Checked) sb.AppendLine($" - 更換機油 ({OIL_CHANGE.ToString("C0", ci)})");
                    if (cbLube.Checked) sb.AppendLine($" - 潤滑保養 ({LUBE.ToString("C0", ci)})");
                    if (cbRadiatorFlush.Checked) sb.AppendLine($" - 水箱清洗 ({RADIATOR_FLUSH.ToString("C0", ci)})");
                    if (cbTransmissionFlush.Checked) sb.AppendLine($" - 變速箱清洗 ({TRANSMISSION_FLUSH.ToString("C0", ci)})");
                    if (cbInspection.Checked) sb.AppendLine($" - 檢驗 ({INSPECTION.ToString("C0", ci)})");
                    if (cbReplaceMuffler.Checked) sb.AppendLine($" - 更換消音器 ({MUFFLER.ToString("C0", ci)})");
                    if (cbTireRotation.Checked) sb.AppendLine($" - 輪胎換位 ({TIRE_ROTATION.ToString("C0", ci)})");
                    sb.AppendLine();

                    decimal serviceAndLabor, partsCost, tax;
                    decimal total = TotalCharges(out serviceAndLabor, out partsCost, out tax);

                    sb.AppendLine("計算過程：");
                    sb.AppendLine($"  服務與工資總額 = 所有選定服務費用 + 工時費用");
                    sb.AppendLine($"    服務與工資總額 = {serviceAndLabor.ToString("C0", ci)}");
                    sb.AppendLine($"  零件費用 = {partsCost.ToString("C0", ci)}");
                    sb.AppendLine($"  稅金 (零件 6%) = {tax.ToString("C0", ci)}");
                    sb.AppendLine($"  總費用 = 服務與工資總額 + 零件費用 + 稅金 = {total.ToString("C0", ci)}");
                    sb.AppendLine();

                    sb.AppendLine("明細小節：");
                    sb.AppendLine($"  服務與工資：{serviceAndLabor.ToString("C0", ci)}");
                    sb.AppendLine($"  零件：{partsCost.ToString("C0", ci)}");
                    sb.AppendLine($"  稅金：{tax.ToString("C0", ci)}");
                    sb.AppendLine($"  總計：{total.ToString("C0", ci)}");

                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.Write(sb.ToString());
                    }

                    MessageBox.Show("儲存成功：" + sfd.FileName, "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 關閉時詢問是否儲存
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (!isCalculated) return;

            var result = MessageBox.Show("是否要將維修明細儲存成檔案？", "儲存確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveServiceDetailsToFile();
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}