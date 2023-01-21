using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            Console.Write("Choose: [r]ock, [p]aper or [s]cissors - ");

            string playerMove = Console.ReadLine();

            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = Rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = Paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = Scissors;
            }
            else
            {
                Console.WriteLine("Wrong Input");
                playerMove = Console.ReadLine();
                return;
            }

            Random random = new Random();
            int computerNumber = random.Next(1, 4);
            string computerMove = "";

            if (computerNumber == 1)
            {
                computerMove = Rock;
            }
            else if (computerNumber == 2)
            {
                computerMove = Paper;
            }
            else
            {
                computerMove = Scissors;
            }

            Console.WriteLine($"The Computer chose {computerMove}.");

            if (playerMove == Rock && computerMove == Scissors || playerMove == Paper && computerMove == Rock || playerMove == Scissors && computerMove == Paper)
            {
                Console.WriteLine("You win!");
            }
            else if (playerMove == Rock && computerMove == Rock || playerMove == Paper && computerMove == Paper || playerMove == Scissors && computerMove == Scissors)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
        }
    }
}
