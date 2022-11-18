using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K19329862_PROG7312_Task1
{
    public partial class ReplacingBooks : Form
    {
        List<string> random = new List<string>();
        List<string> sorted = new List<string>();
        List<string> user = new List<string>();

        // gamification feature variables
        int totalPoints = 0;
        public ReplacingBooks()
        {
            InitializeComponent();
        }

        private void ReplacingBooks_Load(object sender, EventArgs e)
        {
            generateRandom();
        }

        public void generateRandom()
        {
            Random rnd = new Random();
            string randomAlpha;
            int randomFirstNum;
            int randomSecNum;
            int min = 0;
            int max = 999;

            // create random call numbers
            for (int i = 0; i < 10; i++)
            {
                char randomChar1 = (char)rnd.Next('A', 'Z');
                char randomChar2 = (char)rnd.Next('A', 'Z');
                char randomChar3 = (char)rnd.Next('A', 'Z');

                randomFirstNum = rnd.Next(min, max);
                randomSecNum = rnd.Next(min, max);
                randomAlpha = randomChar1.ToString() + randomChar2.ToString() + randomChar3.ToString();
                // Add Call number to both the random and sorted arrays. One will remain the same, and the other will be sorted alphabetically
                random.Add(randomFirstNum.ToString() + '.' + randomSecNum.ToString() + ' ' + randomAlpha);
                sorted.Add(randomFirstNum.ToString() + '.' + randomSecNum.ToString() + ' ' + randomAlpha);
            }

            /** Code Attribution: code created with help of a Stack Overflow question
             * https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number
             * Question by Rella:
             * https://stackoverflow.com/users/434051/rella
             * Answer by Guffa
             * https://stackoverflow.com/users/69083/guffa
             * **/

            // method to sort list - explained in Task1 word document
            sorted.Sort();

            // calls method to display the random list in the buttons
            displayRandom();
        }

        // displays random list in buttons
        public void displayRandom()
        {
            btnOne.Text = random[0];
            btnTwo.Text = random[1];
            btnThree.Text = random[2];
            btnFour.Text = random[3];
            btnFive.Text = random[4];
            btnSix.Text = random[5];
            btnSeven.Text = random[6];
            btnEight.Text = random[7];
            btnNine.Text = random[8];
            btnTen.Text = random[9];
        }


        // coding logic for buttons - allows user to choose call number from buttons and then adds it to user list
        private void btnOne_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnOne.Text);
            btnOne.Enabled = false;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnTwo.Text);
            btnTwo.Enabled = false;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnThree.Text);
            btnThree.Enabled = false;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnFour.Text);
            btnFour.Enabled = false;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnFive.Text);
            btnFive.Enabled = false;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnSix.Text);
            btnSix.Enabled = false;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnSeven.Text);
            btnSeven.Enabled = false;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnEight.Text);
            btnEight.Enabled = false;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnNine.Text);
            btnNine.Enabled = false;
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            lsbUserAnswer.Items.Add(btnTen.Text);
            btnTen.Enabled = false;
        }

        // calls a new form if the user wants to try again
        private void btnTry_Click(object sender, EventArgs e)
        {
            ReplacingBooks new1 = new ReplacingBooks();
            this.Dispose();
            new1.Show();
            lsbUserAnswer.Items.Clear();

            /** Code Attribution: code created with help of a Stack Overflow question
             * https://stackoverflow.com/questions/7725376/reloading-windows-form-without-closing-and-reopening/31124871
             * Question by Miguel Moura:
             * https://stackoverflow.com/users/577805/miguel-moura
             * Answer by Junior CSharp
             * https://stackoverflow.com/users/1792253/junior-csharp
             * **/
        }

        // checks the user's order choice against the sorted list
        private void btnCheck_Click(object sender, EventArgs e)
        {

            // populates user list with the user's order choice
            for (int i = 0; i < lsbUserAnswer.Items.Count; i++)
            {
                string item1 = lsbUserAnswer.Items[i].ToString();
                user.Add(item1);
            }

            if (user.Count < sorted.Count)
            {
                MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
                MessageBox.Show("Error. Insufficient data. Please try again.", "Error", buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            } else
            {
                bool equal = true;
                while (equal == true)
                {
                    for (int j = 0; j < user.Count; j++)
                    {
                        if (sorted[j].Equals(user[j]))
                        {
                            equal = true;
                        } else
                        {
                            equal = false;
                        }
                    }
                }

                if (equal == true)
                {
                    MessageBox.Show("Correct order! You will be awarded 10 points!");
                    // Add 10 points to total points
                    totalPoints = totalPoints + 10;
                    // display points after each round
                    txbPoints.Text = totalPoints.ToString();
                } else
                {
                    MessageBox.Show("Incorrect order. You will be awarded 0 points. Please try again.");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            totalPoints = 0;
            this.Hide();
            frmMain newform = new frmMain();
            newform.ShowDialog();
        }
    }
}
