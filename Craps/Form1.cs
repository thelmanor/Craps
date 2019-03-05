using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**********************************
 * Thelma Nora
 * CIST 2341
 * Mini-Project (Craps)
 * 11/25/2018
 * ******************************/

namespace Craps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dice1 = 0;
        int dice2 = 0;
        int totalscore;
        int pointnum;
        int game1 = 0;
        int count=0;
        Random rn = new Random();
        private void roll_btn_Click(object sender, EventArgs e)
        {
			PlayCraps();
        }
		
        //Method for generating the random numbers  and displaying the dice on the GUI
        public int Roll()
        {
            dice1 = rn.Next(1, 7);
            Console.WriteLine(dice1);
            dice2 = rn.Next(1, 7);
            Console.WriteLine(dice2);

            if (dice1 == 1)
            {
                die1.Image = die1img.Image;
            }
            else if (dice1 == 2)
            {
                die1.Image = die2img.Image;

            }
            else if (dice1 == 3)
            {
                die1.Image = die3img.Image;
            }
            else if (dice1 == 4)
            {
                die1.Image = die4img.Image;
            }
            else if (dice1 == 5)
            {
                die1.Image = die5img.Image;
            }
            else if (dice1 == 6)
            {
                die1.Image = die6img.Image;
            }

            if (dice2 == 1)
            {
                die2.Image = die1img.Image;
            }
            else if (dice2 == 2)
            {
                die2.Image = die2img.Image;
            }
            else if (dice2 == 3)
            {
                die2.Image = die3img.Image;
            }
            else if (dice2 == 4)
            {
                die2.Image = die4img.Image;
            }
            else if (dice2 == 5)
            {
                die2.Image = die5img.Image;
            }
            else if (dice2 == 6)
            {
                die2.Image = die6img.Image;
            }

            totalscore = dice1 + dice2;
            Console.WriteLine("Player rolled:" + totalscore);
            return totalscore;
        }

        // Method for playing the game.
       public  void PlayCraps()
        {
           int firstroll= Roll();   
            // do-while loop that starts the game  to determine if player rolled a winning or lossingnumber on their first try
            do
            {
                //if statement to display winning number on first roll
                if ((firstroll == 7) || (firstroll== 11))
                {
                    Console.WriteLine("Congratulations!!! You Win!");
                    break;

                }
                //if statement to display losing numbers on first roll
                else if ((firstroll == 2) || (firstroll== 3) || (firstroll== 12))
                {
                    Console.WriteLine("Sorry, You Lost!");
                    break;
                }
                //else statement to roll again if the first roll doesn't generate a winning or lossing number 
                else
                {
                    //setting variable for the point number
                    pointnum = firstroll;
                    int newroll = Roll();
                    //if statement to capture possible win on second roll 
                    if (newroll == pointnum)
                        {
                        Console.WriteLine("The point number is:" + pointnum);
                        Console.WriteLine("second roll:Congratulations!!! You Win!");
                        break;
                        }
                    //if statement to capture possible loss on second roll
                    else if (newroll == 7)
                        {
                        Console.WriteLine("The point number is:" + pointnum +"you have rolled a 7");
                        Console.WriteLine("Sorry, You Loss!");
                        break;
                        }
                    //statement to ensure that player keeps rolling if the second roll doesnt match the point number of lossing number
                    if(newroll!=pointnum || newroll!=7){
                            int bonus= Roll();
                        //statement that displays when player finally gets a number matching the point number
                            if (bonus == pointnum)
                            {
                                Console.WriteLine("The point number is:" + pointnum);
                                Console.WriteLine("bonus rolls:Congratulations!!! You Win!");
                                break;
                            }
                        //statement that displays when player finally gets a 7 and losses the game
                        if (bonus == 7)
                            {
                                Console.WriteLine("The point number is:" + pointnum);
                                Console.WriteLine("bonus rolls:You loss!!");
                                break;
                            }
                        count++;   
                    }     
                }
            }
            while (game1<1);            
        }

        private void play_btn_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Would you like to play again?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (answer == DialogResult.No)
            {
                Application.Exit();
            }
            if (answer == DialogResult.Yes)
            {
                die1.Image = null;
                die2.Image = null;
                Console.WriteLine("Roll dice to play again");
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
