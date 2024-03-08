using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OneArmedBandit
{
    public partial class Form1 : Form
    {
        // random number generator
        Random randGen = new Random();
        // int value for score initialized to 10
        int score = 10;


        public Form1()
        {
            InitializeComponent();
        }

        private void spinButton_Click(object sender, EventArgs e) 
        {
            // get random values for each reel (store each in separate int variable)
            int reel1Value = randGen.Next(1, 4);
            int reel2Value = randGen.Next(1, 4);
            int reel3Value = randGen.Next(1, 4);

            // check value of reel 1 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (reel1Value)
            {
                case 1:
                    pictureBox1.BackgroundImage = Properties.Resources.cherry_100x125;
                    break;
                
                case 2:
                    pictureBox1.BackgroundImage = Properties.Resources.diamond_100x125;
                    break;

                case 3:
                    pictureBox1.BackgroundImage = Properties.Resources._7_100x125; 
                    break;
            }




            // check value of reel 2 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (reel2Value)
                    {
                        case 1:
                            pictureBox2.BackgroundImage = Properties.Resources.cherry_100x125;
                            break;

                        case 2:
                            pictureBox2.BackgroundImage = Properties.Resources.diamond_100x125;
                            break;

                        case 3:
                            pictureBox2.BackgroundImage = Properties.Resources._7_100x125;
                            break;
            }


            // check value of reel 3 with a switch statement to set appropriate image to
            // BackgroundImage property of pictureBox. Get images from Properties.Resources

            switch (reel3Value)
                            {
                         case 1:
                             pictureBox3.BackgroundImage = Properties.Resources.cherry_100x125;
                             break;

                         case 2:
                             pictureBox3.BackgroundImage = Properties.Resources.diamond_100x125;
                             break;

                         case 3:
                             pictureBox3.BackgroundImage = Properties.Resources._7_100x125;
                             break;
            }


            /// STOP HERE ----------------------------------------------------------
            /// Test to make sure that your program will display random
            /// images to each reel. Only continue on after you know this works
            /// --------------------------------------------------------------------


            // Use compound if statement to check if all reels are equal. 
            // If yes show "winner" statement and add 3 to score.
            // If no show "play again" statement and subtract 1 from score.

            if (reel1Value == reel2Value && reel2Value == reel3Value)
            {
                // All reels are equal
                score += 3; // Add 3 to the score
                outputLabel.Text = "Winner!"; 
            }
            else
            {
                // Reels are not equal
                score -= 1; // Subtract 1 from the score
                outputLabel.Text = "Play again"; 
            }


            // if score has reached 0 display "lose" message and set button enabled property to false

            if (score <= 0)
            {
                // Score has reached 0 
                outputLabel.Text = "You Lose!"; 
                spinButton.Enabled = false; // Disable the spin button
            }


            // display updated score
            outputLabel.Text = $"{score}";

        }
        
    }
}
     
