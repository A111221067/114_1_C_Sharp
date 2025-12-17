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

namespace Test_Score_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void ReadScores(List<int> scoresList)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Title = "請選擇分數檔案";
            openFile.Filter = "文字檔案 (*.txt)|*.txt|所有檔案 (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader inputFile = File.OpenText(openFile.FileName);

                    scoresList.Clear();

                    while (!inputFile.EndOfStream)
                    {
                        scoresList.Add(int.Parse(inputFile.ReadLine()));
                    }

                    inputFile.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("您取消了檔案選取。");
            }
        }

        private void DisplayScores(List<int> scoresList)
        {
            testScoresListBox.Items.Clear(); 
            foreach (int score in scoresList)
            {
                testScoresListBox.Items.Add(score);
            }
        }

        private double Average(List<int> scoresList)
        {
            double total = 0;
            foreach (int score in scoresList)
            {
                total += score;
            }
            return total / scoresList.Count;
        }

        private int AboveAverage(List<int> scoresList, double average)
        {
            int count = 0;
            foreach (int score in scoresList)
            {
                if (score > average) count++;
            }
            return count;
        }

        private int BelowAverage(List<int> scoresList)
        {
            double avg = Average(scoresList); 
            int count = 0;
            foreach (int score in scoresList)
            {
                if (score < avg) count++;
            }
            return count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            List<int> scoresList = new List<int>();
            ReadScores(scoresList);


            if (scoresList.Count > 0)
            {

                DisplayScores(scoresList);


                double averageScore = Average(scoresList);
                averageLabel.Text = averageScore.ToString("n1");


                int numAboveAverage = AboveAverage(scoresList, averageScore);
                aboveAverageLabel.Text = numAboveAverage.ToString();


                int numBelowAverage = BelowAverage(scoresList);
                belowAverageLabel.Text = numBelowAverage.ToString();
            }
        }
    }
}