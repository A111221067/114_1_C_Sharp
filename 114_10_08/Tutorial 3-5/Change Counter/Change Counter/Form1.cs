using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;    
        const decimal TWENTY_FIVE_CENTS =25.0m;    
        const decimal FIFTY_CENTS =50.0m;  


        private decimal total;
        private int fiveCentsCount = 0;
        private int tenCentsCount = 0;
        private int twentyFiveCentsCount = 0;
        private int fiftyCentsCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private decimal CalculateTotal()
        {
            return fiveCentsCount * 0.05m +
                   tenCentsCount * 0.10m +
                   twentyFiveCentsCount * 0.25m +
                   fiftyCentsCount * 0.50m;
        }

        private void UpdateTotalDisplay()
        {
            totalLabel.Text = $"{CalculateTotal():C2}";
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
           
            total = total +=5; 
            totalLabel.Text= total.ToString();
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
          
            total = total +=10;
            totalLabel.Text = total.ToString();

           
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            
            total = total +=25;
            totalLabel.Text = total.ToString();
            
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total = total +=50;
            totalLabel.Text = total.ToString();
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
