using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void francePictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "法國";
        }

        private void germanPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "德國";
        }
        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "芬蘭";
        }

    }
}
