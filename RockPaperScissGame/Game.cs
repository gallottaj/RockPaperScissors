using System;
using System.Collections.Generic;
using System.Text;

//generate random number to determine the computer's selection
//get user input
// display computer's choice
//compete
//choose a winner
//exception if tie

namespace RockPaperScissGame
{
    class Game
    {
        public static Random random = new Random();
        public static int computerChoiceNum;
        public static int userChoiceNum;
        public static string computerChoiceName;
        public static string userChoiceName;
        public static string winner = "no one";

        //constructor

        public Game()
        {
            //set computer choice

            computerChoiceNum = random.Next(1, 3);

        }

        public void computerChoice()
        {
            // computer

            if (computerChoiceNum == 1)
            {
                computerChoiceName = "Rock";
            }
            if (computerChoiceNum == 2)
            {
                computerChoiceName = "Paper";
            }
            if (computerChoiceNum == 3)
            {
                computerChoiceName = "Scissors";
            }

            // for testing

            //Console.WriteLine("computer chooses" + " " + computerChoiceName);

        }

        public void userChoice()
        {
            //takes uer input from the console and converts to string

            Console.Write("please enter a number between 1 and 3:");
            userChoiceNum = Convert.ToInt32(Console.ReadLine());

            if (userChoiceNum == 1)
            {
                userChoiceName = "Rock";
            }
            if (userChoiceNum == 2)
            {
                userChoiceName = "Paper";
            }
            if (userChoiceNum == 3)
            {
                userChoiceName = "Scissors";
            }

            // displays choices as string

            Console.Write("you chose" + " " + userChoiceName);
            Console.WriteLine(" " + "the computer chose" + " " + computerChoiceName);

        }

        public void compete()
        {
                if (computerChoiceNum == 1 && userChoiceNum == 3) // computer has rock; user has scissors (computer wins)
                {
                winner = "computer";

                }
                if (userChoiceNum == 1 && computerChoiceNum == 3) // user has rock; computer has scissors (user wins)
                {
                    winner = "user";
                }
                if (computerChoiceNum == 2 && userChoiceNum == 3) // computer has paper; user has scissors (user wins)
                {
                    winner = "user";
                }
                if (computerChoiceNum == 3 && userChoiceNum == 2) // user has paper; computer has scissors (computer wins)
                {
                    winner = "computer";
                }
                if (computerChoiceNum == 2 && userChoiceNum == 1) // computer has paper; user has rock (computer wins)
                {
                    winner = "computer";
                }
                if (computerChoiceNum == 1 && userChoiceNum == 2) // computer has rock; user has paper (user wins)
                {
                    winner = "user";
                }
                else if (computerChoiceNum == userChoiceNum)
                {
                Console.Write("it's a tie! try again");
                }
        }

        public void gameWinner()
        {
            {
                Console.Write(" " + winner + " " + "wins!");
            }

        }

    }

}
