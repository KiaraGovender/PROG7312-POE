using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace K19329862_PROG7312_Task1
{
    public partial class FindingCallNumbers : Form
    {
        static Random rnd = new Random();

        List<string> firstLevel = new List<string>();
        List<string> secondLevel = new List<string>();
        List<string> thirdLevel = new List<string>();
        List<string> topLevelOptions = new List<string>();
        List<string> secLevelOptions = new List<string>();

        // global variables
        String[] strlist;
        String firstCorrect = "";
        String firstChoice = "";
        int totalScore = 0;
        public FindingCallNumbers()
        {
            InitializeComponent();
        }

        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            ReadCallNumbers();
            startFind();
        }

        public void startFind() 
        {
            /** CODE ATTRIBUTION: code created with help of GeeksForGeeks questions
             * https://www.geeksforgeeks.org/string-split-method-in-c-sharp-with-examples/
             * by Parth Maniyar:
             * https://auth.geeksforgeeks.org/user/ParthManiyar/articles (23 July 2019)
             * **/
            int r = rnd.Next(thirdLevel.Count);
            String option = thirdLevel[r]; 

            String[] spearator = { "-" };
            Int32 count = 2;

            strlist = option.Split(spearator, count,
               StringSplitOptions.RemoveEmptyEntries);

            lblRandom.Text = strlist[1];
            chooseOptions();
        }

        public void chooseOptions()
        {
            int numberOption = Int32.Parse(strlist[0]);
            
            // Gets correct first level answer
            if (numberOption > 0 && numberOption < 100)
                firstCorrect = "000 Generalities";

            if (numberOption > 100 && numberOption < 200)
                firstCorrect = "100 Philosophy & psychology";

            if (numberOption > 200 && numberOption < 300)
                firstCorrect = "200 Religion";

            if (numberOption > 300 && numberOption < 400)
                firstCorrect = "300 Social Sciences";

            if (numberOption > 400 && numberOption < 500)
                firstCorrect = "400 Language";

            if (numberOption > 500 && numberOption < 600)
                firstCorrect = "500 Natural sciences & mathematics";

            if (numberOption > 600 && numberOption < 700)
                firstCorrect = "600 Technology (Applied sciences)s";

            if (numberOption > 700 && numberOption < 800)
                firstCorrect = "700 The arts";

            if (numberOption > 800 && numberOption < 900)
                firstCorrect = "800 Literature & rhetoric";

            if (numberOption > 900)
                firstCorrect = "900 Geography & history";

           
            // Gets 3 random options form first level list and adds it to list
            for (int i = 0; i < 3; i++)
            {
                int r = rnd.Next(firstLevel.Count);
                String opt = firstLevel[r];

                String[] spearator = { "!" };
                Int32 count = 2;

                String[] stlist = opt.Split(spearator, count,
                       StringSplitOptions.RemoveEmptyEntries);

                topLevelOptions.Add(stlist[0]);
            }
            topLevelOptions.Add(firstCorrect);

            topLevelOptions.Sort();
            displayTopLevel();

        }

        public void checkAnswer()
        {
            if (firstChoice == firstCorrect)
            {
                MessageBox.Show("Correct! You will be awarded 10 points.");
                totalScore = totalScore + 10;
                lblScore.Text = "Total Points: " + totalScore;
                ReadCallNumbers();
                startFind();
                // nextLevel();
            } else
            {
                MessageBox.Show("Wrong Option. Try Again.");
                this.Hide();
                FindingCallNumbers new1 = new FindingCallNumbers();
                new1.ShowDialog();
            }
        }

        public void displayTopLevel()
        {
            btnAnsw1.Text = topLevelOptions[0];
            btnAnsw2.Text = topLevelOptions[1];
            btnAnsw3.Text = topLevelOptions[2];
            btnAnsw4.Text = topLevelOptions[3];
        }

        // after correct answer
        public void nextLevel()
        {
            btnSec1.Visible = true;
            btnSec2.Visible = true;
            btnSec3.Visible = true;
            btnSec4.Visible = true;

            for (int i = 0; i < 4; i++)
            {
                int r = rnd.Next(secondLevel.Count);
                String opt = secondLevel[r];

                String[] spearator = { "!" };
                Int32 count = 2;

                String[] stlist = opt.Split(spearator, count,
                       StringSplitOptions.RemoveEmptyEntries);

                secLevelOptions.Add(stlist[0]);
            }

            // display data in buttons
            btnSec1.Text = secLevelOptions[0];
            btnSec2.Text = secLevelOptions[1];
            btnSec2.Text = secLevelOptions[2];
            btnSec2.Text = secLevelOptions[3];
        }
        public void ReadCallNumbers()
        {
            /** CODE ATTRIBUTION: code created with help of StackOverflow questions
             * https://stackoverflow.com/questions/22233688/read-from-text-file-with-multiple-delimiters-and-organize-into-objects
             * Question by khmer2040:
             * https://stackoverflow.com/users/2925538/khmer2040
             * Answer by Nilzor:
             * https://stackoverflow.com/users/507339/nilzor
             * **/

            //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE
            FileStream mediaFile = new FileStream(@"C:\Users\Kiara\Desktop\19329862_PROG7312_POE\k19329862CallNumbers.txt", FileMode.Open, FileAccess.Read);
            StreamReader mediaData = new StreamReader(mediaFile);

            string eachRow;
            // splits data from text file into different lists
            while ((eachRow = mediaData.ReadLine()) != null) 
            {
                if (eachRow.StartsWith("!")){
                    firstLevel.Add(eachRow);
                }
                else
                {
                    if (eachRow.StartsWith("@"))
                    {
                        secondLevel.Add(eachRow);
                    } 
                    else
                    {
                        thirdLevel.Add(eachRow);
                    }
                }
            }

            /**
             * Testing if data is correctly read
            for (int i=0; i < firstLevel.Count; i++)
            {
                listBox1.Items.Add(firstLevel[i]);
            }**/
        }

        public void clearAll()
        {
            firstLevel.Clear();
            secondLevel.Clear();
            thirdLevel.Clear();
            topLevelOptions.Clear();
            totalScore = 0;
            lblScore.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnsw1_Click(object sender, EventArgs e)
        {
            firstChoice = btnAnsw1.Text;
            checkAnswer();
        }

        private void btnAnsw2_Click(object sender, EventArgs e)
        {
            firstChoice = btnAnsw2.Text;
            checkAnswer();
        }

        private void btnAnsw3_Click(object sender, EventArgs e)
        {
            firstChoice = btnAnsw3.Text;
            checkAnswer();
        }

        private void btnAnsw4_Click(object sender, EventArgs e)
        {
            firstChoice = btnAnsw4.Text;
            checkAnswer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            clearAll();
            this.Hide();
            frmMain newform = new frmMain();
            newform.ShowDialog();
        }
    }
}
