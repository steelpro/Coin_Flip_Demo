using System;
using System.Windows.Forms;

namespace coinFlip {
    public partial class Form1 : Form {
        public Form1() { InitializeComponent(); }
        private void btnFlip_Click(object sender, EventArgs e) {
            Random rand = new Random();
            int toss = rand.Next(2);
            if (toss == 0) {
                pbHeads.Visible = true;
                pbTails.Visible = false;
            }
            else {
                pbHeads.Visible = false;
                pbTails.Visible = true;
            }
        }
    }
}