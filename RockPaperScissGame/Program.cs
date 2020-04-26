using System;

namespace RockPaperScissGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Game g = new Game();
            g.computerChoice();
            g.userChoice();
            g.compete();
            g.gameWinner();

        }
    }
}
