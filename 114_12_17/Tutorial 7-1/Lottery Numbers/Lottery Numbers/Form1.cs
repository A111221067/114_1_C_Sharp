using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            firstLabel.Text = rand.Next(10).ToString();
            secondLabel.Text = rand.Next(10).ToString();
            thirdLabel.Text = rand.Next(10).ToString();
            fourthLabel.Text = rand.Next(10).ToString();
            fifthLabel.Text = rand.Next(10).ToString();
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
