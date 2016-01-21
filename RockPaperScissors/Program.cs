using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display display = new Display();
            //display.GetPlayer1Name();
            //display.GetPlayer2Name();
            //display.StoreResults();

            Game game = new Game();
            Round round = new Round();
            round.ScoreRound();
            round.DetermineWinner();

            
            
            
            
            
            

        }
    }
}
