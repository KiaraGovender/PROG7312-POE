using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K19329862_PROG7312_Task1
{
    public partial class IdentifyingAreas : Form
    {
        List<string> keys = new List<string>();
        List<string> values = new List<string>();

        // variables
        int totalPoints = 0;
        // Determines if pair exists in Dictionary
        int roundPoints = 0;
        public IdentifyingAreas()
        {
            InitializeComponent();
        }

     // Store top-level Dewey call numbers and descriptions in Dictionary
    private static Dictionary<string, string> dewey = new Dictionary<string, string>() 
    {
      {
        "000-099",
        "General Works"
      },
      {
        "100-199",
        "Philsophy and Psychology"
      },
      {
        "200-299",
        "Religion"
      },
      {
        "300-399",
        "Social Sciences"
      },
      {
        "400-499",
        "Language"
      },
      {
        "500-599",
        "Natural Sciences and Mathematics"
      },
      {
        "600-699",
        "Technology"
      },
      {
        "700-799",
        "The Arts"
      },
      {
        "800-899",
        "Literature and Rhetoric"
      },
      {
        "900-999",
        "History, Biography and Geography"
      },
    };

        // Add key and values to different lists
        /** CODE ATTRIBUTION: code created with help of StackOverflow questions
         * https://stackoverflow.com/questions/69886562/c-sharp-how-to-match-items-from-two-list-boxes
         * Question by Bavish:
         * https://stackoverflow.com/users/17031936/bavish
         * Answer by Joseph Flames:
         * https://stackoverflow.com/users/17358811/jos%c3%a9ph-flames
         * **/
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> kvp in dewey)
            {
                keys.Add(kvp.Key);
                values.Add(kvp.Value);
            }

            Random rdm = new Random();
            int num = rdm.Next(0, 2);
            
            // If statement to call alternate methods for matching call no. and desc.
            if (num == 0)
            {
                // method to match description to call number
                callFirst();
            } else
            {
                // method to match call number to description
                descVoid();
            }
        }

        private void callFirst()
        {
            // Creates lists with random calls and description
            Random rnd = new Random();
            List<string> calls = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                int r = rnd.Next(keys.Count);
                calls.Add(keys[r]);
            }
            // input data to labels
            lblOne.Text = calls[0];
            lblTwo.Text = calls[1];
            lblThree.Text = calls[2];
            lblFour.Text = calls[3];

            List<string> desc = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                int r = rnd.Next(values.Count);
                desc.Add(values[r]);
            }
            // input data to buttons
            btn1.Text = desc[0];
            btn2.Text = desc[1];
            btn3.Text = desc[2];
            btn4.Text = desc[3];
            btn5.Text = desc[4];
            btn6.Text = desc[5];
            btn7.Text = desc[6];
        }

        private void descVoid()
        {
            Random rnd = new Random();
            List<string> desc = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                int r = rnd.Next(values.Count);
                desc.Add(values[r]);
            }
            // input data to labels
            lblOne.Text = desc[0];
            lblTwo.Text = desc[1];
            lblThree.Text = desc[2];
            lblFour.Text = desc[3];

            List<string> calls = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                int r = rnd.Next(keys.Count);
                calls.Add(keys[r]);
            }
            // input data to buttons
            btn1.Text = calls[0];
            btn2.Text = calls[1];
            btn3.Text = calls[2];
            btn4.Text = calls[3];
            btn5.Text = calls[4];
            btn6.Text = calls[5];
            btn7.Text = calls[6];
        }


        // When user clicks on button, the text is added to the list box
        private void btn1_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn1.Text);
            btn1.Enabled = false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn2.Text);
            btn2.Enabled = false;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn3.Text);
            btn3.Enabled = false;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn4.Text);
            btn4.Enabled = false;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn5.Text);
            btn5.Enabled = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn6.Text);
            btn6.Enabled = false;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lsbChoice.Items.Add(btn7.Text);
            btn7.Enabled = false;
        }

        private void lblTwo_Click(object sender, EventArgs e)
        {

        }

        private void lblThree_Click(object sender, EventArgs e)
        {

        }

        private void lblOne_Click(object sender, EventArgs e)
        {

        }

        private void lblFour_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            

            /** CODE ATTRIBUTION: code created with help of StackOverflow questions
             * https://stackoverflow.com/questions/9650355/how-to-check-if-a-key-value-pair-exists-in-a-dictionary/9650379
             * Question by user1261466:
             * https://stackoverflow.com/users/1261466/user1261466
             * Answer by Wesley Long:
             * https://stackoverflow.com/users/820068/wesley-long
             * **/
            if (dewey.ContainsKey(lblOne.Text) && dewey[lblOne.Text].Equals(lsbChoice.Items[0]))
            {
                roundPoints = roundPoints + 10;
            }
            if (dewey.ContainsKey(lblTwo.Text) && dewey[lblTwo.Text].Equals(lsbChoice.Items[1]))
            {
                roundPoints = roundPoints + 10;
            }
            if (dewey.ContainsKey(lblThree.Text) && dewey[lblThree.Text].Equals(lsbChoice.Items[2]))
            {
                roundPoints = roundPoints + 10;
            }
            if (dewey.ContainsKey(lblFour.Text) && dewey[lblFour.Text].Equals(lsbChoice.Items[3]))
            {
                roundPoints = roundPoints + 10;
            }

            // Points for each round and total session (totalPoints)
            MessageBox.Show("Points this round: " + roundPoints);
            totalPoints = totalPoints + roundPoints;

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            IdentifyingAreas new1 = new IdentifyingAreas();
            MessageBox.Show("Total points so far: " + totalPoints);
            this.Dispose();
            new1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Final points: " + totalPoints);
            this.Hide();
            frmMain newform = new frmMain();
            newform.ShowDialog();

            // Session ends, total points are set to zero
            totalPoints = 0;
        }
    }
}
