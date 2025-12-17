using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計算平均
        private double Average(int[] scores)
        {
            double total = 0;

            foreach (int score in scores)
            {
                total += score;
            }

            return total / scores.Length;
        }

        // 取得最高分
        private int Highest(int[] scores)
        {
            int highest = scores[0];

            foreach (int score in scores)
            {
                if (score > highest)
                {
                    highest = score;
                }
            }

            return highest;
        }

        // 取得最低分
        private int Lowest(int[] scores)
        {
            int lowest = scores[0];

            foreach (int score in scores)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }

            return lowest;
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            List<int> scoreList = new List<int>();

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader inputFile = File.OpenText(openFile.FileName);

                while (!inputFile.EndOfStream)
                {
                    int score = int.Parse(inputFile.ReadLine());
                    scoreList.Add(score);
                    testScoresListBox.Items.Add(score);
                }

                inputFile.Close();

                int[] scores = scoreList.ToArray();

                highScoreLabel.Text = Highest(scores).ToString();
                lowScoreLabel.Text = Lowest(scores).ToString();
                averageScoreLabel.Text = Average(scores).ToString("n2");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
