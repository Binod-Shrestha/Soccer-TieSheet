using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A1BinodShrestha
{
    public partial class Home : Form
    {
        Random rnd = new Random();
        string[] teams =  {"Nepal", "Bhutan", "Australia", "India", "Shrilanka",
                "England", "Pakistan", "Canada", "UAE", "Malayasia", "USA", "Bangaladesh" };
        string[] teamz; 

        public Home()
        {
            InitializeComponent();
            btnPlay4.Enabled = false;
            btnPlay3.Enabled = false;
            btnPlay1.Enabled = false;
            btnPlay2.Enabled = false;
            btnPlay5.Enabled = false;
            btnPlay6.Enabled = false;
            btnPlay7.Enabled = false;
            btnResetGame.Enabled = false;

            
            
        }// end of Home constructor

        private void Home_Load(object sender, EventArgs e)
        {
            lstBxTeams.Items.AddRange(teams);
            teamz = teams;
        } // end of Home Form method

        private void btnDrawTeams_Click(object sender, EventArgs e)
        {
            btnResetGame.Enabled = false;

            for (int i = 0; i < 8; i++)
            {
                int num = rnd.Next(8);
                shuffle(i, num);
            }
                        
            lblQf1.Text = teams[0];
            lblQf1team1.Text = teams[1];
            lblQf1team3.Text = teams[2];
            lblQf1team4.Text = teams[3];
            lblQf2Team5.Text = teams[4];
            lblQf2team6.Text = teams[5];
            lblQf2Team7.Text = teams[6];
            lblQf2Team8.Text = teams[7];

            //buttons disabled
            btnPlay1.Enabled = true;
            btnPlay2.Enabled = false;
            btnPlay3.Enabled = false;
            btnPlay4.Enabled = false;
            btnPlay4.Enabled = false;
            btnPlay5.Enabled = false;
            btnPlay6.Enabled = false;
            btnPlay7.Enabled = false;
        } // end of draw button function


        public void shuffle(int i, int num)
        {
            String temp = teamz[i];
            teamz[i] = teams[num];
            teams[num] = temp;

        }// end of shuffle method
             

        private void btnResetGame_Click(object sender, EventArgs e)
        {
           
            // clearing labels
            lblQf1.ResetText();
            lblQf1team1.ResetText();
            lblQf1team3.ResetText();
            lblQf1team4.ResetText();
            lblQf2Team5.ResetText();
            lblQf2team6.ResetText();
            lblQf2Team7.ResetText();
            lblQf2Team8.ResetText();

            // resetting team labels
            lblSF1.ResetText();
            lblSF2.ResetText();
            lblSF3.ResetText();
            lblSF4.ResetText();
            lblF1.ResetText();
            lblF2.ResetText();

            //resetting goal labels
            lblGl1.ResetText();
            lblGl2.ResetText();
            lblGl3.ResetText();
            lblGl4.ResetText();
            lblGl5.ResetText();
            lblGl6.ResetText();
            lblGl7.ResetText();
            lblGl8.ResetText();
            lblGl9.ResetText();
            lblGl10.ResetText();
            lblGl11.ResetText();
            lblGl12.ResetText();
            lblGl13.ResetText();
            lblGl14.ResetText();

           
            btnDrawTeams.Enabled = true;


        }// end of reset button function

        // Button Functions

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            int team1Gl =  rnd.Next(0, 11);
            int team2Gl = rnd.Next(0, 11);

            lblGl1.Text = team1Gl.ToString();
            lblGl2.Text = team2Gl.ToString();
            if (team1Gl.Equals(team2Gl))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay1.Enabled = true;
                btnPlay2.Enabled = false;


            }
            else if (team1Gl > team2Gl)
            {
                lblGl1.ForeColor = System.Drawing.Color.Green;
                lblGl2.ForeColor = System.Drawing.Color.Red;
                lblSF1.Text = lblQf1.Text;
                btnPlay1.Enabled = false;
            }
            else
            {
                lblSF1.Text = lblQf1team1 .Text;
                lblGl1.ForeColor = System.Drawing.Color.Red;
                lblGl2.ForeColor = System.Drawing.Color.Green;
                btnPlay1.Enabled = false;
          
            }
            btnPlay2.Enabled = true;
            btnDrawTeams.Enabled = false;
        } // end of playButton-1

        private void btnPlay2_Click(object sender, EventArgs e)
        {
            int team1G3 = rnd.Next(0, 11);
            int team2G4 = rnd.Next(0, 11);

            lblGl3.Text = team1G3.ToString();
            lblGl4.Text = team2G4.ToString();
            if (team1G3.Equals(team2G4))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay2.Enabled = true;
                btnPlay6.Enabled = false;

            }
            else if (team1G3 > team2G4)
            {
                lblGl3.ForeColor = System.Drawing.Color.Green;
                lblGl4.ForeColor = System.Drawing.Color.Red;
                lblSF2.Text = lblQf1team3.Text;
                btnPlay2.Enabled = false;
            }
            else
            {
                lblSF2.Text = lblQf1team4 .Text;
                lblGl3.ForeColor = System.Drawing.Color.Red;
                lblGl4.ForeColor = System.Drawing.Color.Green;
                btnPlay2.Enabled = false;
            }
          //  btnPlay3.Enabled = true;
            btnPlay1.Enabled = false;
            btnPlay6.Enabled = true;
        }// end of btnplay2

        private void btnPlay3_Click(object sender, EventArgs e)
        {
            int team1G5 = rnd.Next(0, 11);
            int team2G6 = rnd.Next(0, 11);

            lblGl5.Text = team1G5.ToString();
            lblGl6.Text = team2G6.ToString();
            if (team1G5.Equals(team2G6))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay3.Enabled = true;
                btnPlay5.Enabled = false;
            }
            else if (team1G5 > team2G6)
            {
                lblGl5.ForeColor = System.Drawing.Color.Green;
                lblGl6.ForeColor = System.Drawing.Color.Red;
                lblF1.Text = lblSF1.Text;
                btnPlay3.Enabled = false;
            }
            else
            {
                lblGl5.ForeColor = System.Drawing.Color.Red;
                lblGl6.ForeColor = System.Drawing.Color.Green;
                lblF1.Text = lblSF2.Text;
                btnPlay3.Enabled = false;
            }
            btnPlay2.Enabled = false;
            btnPlay5.Enabled = true;
        }//end of playButton3

        private void btnPlay4_Click(object sender, EventArgs e)
        {
            int team1G7 = rnd.Next(0, 11);
            int team2G8 = rnd.Next(0, 11);

            lblGl7.Text = team1G7.ToString();
            lblGl8.Text = team2G8.ToString();
            if (team1G7.Equals(team2G8))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay4.Enabled = true;
                btnPlay5.Enabled = false;

            }
            else if (team1G7 > team2G8)
            {
                lblGl7.ForeColor = System.Drawing.Color.Green;
                lblGl8.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Congratulations! Team " + lblF1.Text);
                btnPlay4.Enabled = false;
            }
            else
            {
                lblGl7.ForeColor = System.Drawing.Color.Red;
                lblGl8.ForeColor = System.Drawing.Color.Green;
                MessageBox.Show("Congratulations! Team " + lblF2.Text);
                btnPlay4.Enabled = false;
            }
            btnResetGame.Enabled = true;
        }

        private void btnPlay5_Click(object sender, EventArgs e)
        {
         
            int team1G9 = rnd.Next(0, 11);
            int team2G10 = rnd.Next(0, 11);

            lblGl9.Text = team1G9.ToString();
            lblGl10.Text = team2G10.ToString();
            if (team1G9.Equals(team2G10))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay5.Enabled = true;
                btnPlay4.Enabled = false;

            }
            else if (team1G9 > team2G10)
            {
                lblGl9.ForeColor = System.Drawing.Color.Green;
                lblGl10.ForeColor = System.Drawing.Color.Red;
                lblF2.Text = lblSF3.Text;
                btnPlay5.Enabled = false;
            }
            else
            {
                lblGl9.ForeColor = System.Drawing.Color.Red;
                lblGl10.ForeColor = System.Drawing.Color.Green;
                lblF2.Text = lblSF4.Text;
                btnPlay5.Enabled = false;
            }
                    
            btnPlay4.Enabled = true;
        }

        private void btnPlay6_Click(object sender, EventArgs e)
        {
           
            int team1G11 = rnd.Next(0, 11);
            int team2G12 = rnd.Next(0, 11);

            lblGl11.Text = team1G11.ToString();
            lblGl12 .Text = team2G12.ToString();
            if (team1G11.Equals(team2G12))
            {
                MessageBox.Show("Tie.Play Again!");
                btnPlay6.Enabled = true;
                btnPlay7.Enabled = false;

            }
            else if (team1G11 > team2G12)
            {
                lblGl11.ForeColor = System.Drawing.Color.Green;
                lblGl12.ForeColor = System.Drawing.Color.Red;
                lblSF3 .Text = lblQf2Team5.Text;
                btnPlay6.Enabled = false;
            }
            else
            {

                lblGl11.ForeColor = System.Drawing.Color.Red;
                lblGl12.ForeColor = System.Drawing.Color.Green;
                lblSF3 .Text =lblQf2team6 .Text;
                btnPlay6.Enabled = false;
            }
            btnPlay7.Enabled = true;
        }

        private void btnPlay7_Click(object sender, EventArgs e)
        {
            int team1G13 = rnd.Next(0, 11);
            int team2G14 = rnd.Next(0, 11);

            lblGl13.Text = team1G13.ToString();
            lblGl14.Text = team2G14.ToString();

            if (team1G13.Equals(team2G14))
            {
               
                MessageBox.Show("Tie.Play Again!");
                btnPlay7.Enabled = true;
                btnPlay3.Enabled = false;

            }
            else if (team1G13 > team2G14)
            {
                lblGl13.ForeColor = System.Drawing.Color.Green;
                lblGl14.ForeColor = System.Drawing.Color.Red;
                lblSF4.Text = lblQf2Team7 .Text;
                btnPlay7.Enabled = false;
            }
            else
            {
                lblGl13.ForeColor = System.Drawing.Color.Red;
                lblGl14.ForeColor = System.Drawing.Color.Green;
                lblSF4.Text = lblQf2Team8.Text;
                btnPlay7.Enabled = false;
            }
                 btnPlay6.Enabled = false;
                 btnPlay3.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
