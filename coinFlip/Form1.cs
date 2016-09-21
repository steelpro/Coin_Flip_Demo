using System;
using System.Windows.Forms;
/* Zachary Betters
 * CIS 209
 * Sept 14, 2016
 * Coin Flipper
 * This program will simulate a coin toss
 */
namespace coinFlip {
    public partial class Form1 : Form {

        //all variables to be used are declared
        double headsCount, tailsCount, totCount, headsPerc, tailsPerc;

        private void btnExit_Click(object sender, EventArgs e) { Close(); }

        public Form1() { InitializeComponent(); }

        private void btnFlip_Click(object sender, EventArgs e) {            
            Random rand = new Random();
            int toss = rand.Next(2);
            if (toss == 0) { //random number used for toss decides side of coin
                pbHeads.Visible = true;
                pbTails.Visible = false;
                headsCount++; //if heads, number of heads is added by 1                 
            }
            else {
                pbHeads.Visible = false;
                pbTails.Visible = true;
                tailsCount++;
            }

            totCount = tailsCount + headsCount; 
            //percentages are decided by dividing by total 
            headsPerc = (headsCount / totCount) * 100;
            tailsPerc = (tailsCount / totCount) * 100;
            
            lblHeads.Text = "Heads: " + headsPerc.ToString("F") + "%, #" + headsCount;
            lblTails.Text = "Tails: " + tailsPerc.ToString("F") + "%, #" + tailsCount;
            lblTotal.Text = "Total: " + totCount;
        }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}