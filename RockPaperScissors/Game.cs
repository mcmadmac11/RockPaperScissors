using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
    public class Game
    {
        Player player1;
        Player player2;

        

        public void StartNewGame()
        {
            Console.WriteLine("New Game started");
            Round round = new Round();
            round.ScoreRound();
            round.DetermineWinner();
        }






    }
}
