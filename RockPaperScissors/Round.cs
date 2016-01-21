using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Round
    {
        Player player1 = new Player();
        Player player2 = new Player();
        int Player1Selection;
        int Player2Selection;
        List<int> playerChoices = new List<int>();
        List<int> PlayerChoices = new List<int>();

        public List<int> ScoreRound()
        {
            
            
            Console.WriteLine("{0} Turn: Please make a selection", player1);
            Console.WriteLine(" [1] = Rock \n [2] = Paper \n [3] = Scissors");
            Player1Selection = Convert.ToInt32(Console.ReadLine());
            playerChoices.Add(Player1Selection);
            Console.ReadKey(true);
            Console.WriteLine("{0} Turn: Please make a selection", player2);
            Console.WriteLine(" [1] = Rock \n [2] = Paper \n [3] = Scissors");
            Player2Selection = Convert.ToInt32(Console.ReadLine());

            playerChoices.Add(Player2Selection);

            return playerChoices;
        }
        string Tie;
        string Wins;
        int winner;

        public string DetermineWinner()
        {
            PlayerChoices = playerChoices;
            winner = (3 + PlayerChoices[0] - PlayerChoices[1]) % 3;

            if (winner == 1)
            {
                Console.WriteLine("Player 1 Wins");
                return Player1Selection.ToString(); 
            }
            else if (winner == 2)
            {
                Console.WriteLine("Player 2 Wins!");
                return Player2Selection.ToString();
            }
            else
            {
                Console.WriteLine("You tied!");
                return Tie;
            }
        }


        //int wins = 0;
        //int losses = 0;
        //int ties = 0;

        //int a;
        //int b;
        
        //public void gameLogic()
        //{

        //    if (a == b)
        //    {
        //        ties++;
        //    }
        //    else if ((a - b) % 3 == 1)
        //    {
        //        wins++;
        //    }
        //    else losses++;
        //}
    }
}
