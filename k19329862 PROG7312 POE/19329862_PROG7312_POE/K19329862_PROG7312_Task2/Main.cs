using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace K19329862_PROG7312_Task1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReplacingBooks newform = new ReplacingBooks();
            newform.ShowDialog();
        }

        private void btnIdentify_Click(object sender, EventArgs e)
        {
            this.Hide();
            IdentifyingAreas newform = new IdentifyingAreas();
            newform.ShowDialog();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            // opens FindingCallNumbers form
            this.Hide();
            FindingCallNumbers newform = new FindingCallNumbers();
            newform.ShowDialog();
        }
    }
}
