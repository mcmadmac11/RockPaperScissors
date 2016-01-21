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

        public void StartNewGame()
        {
            Player player1 = new Player();
            Player player2 = new Player();
            Display display = new Display();
            display.GetPlayer1Name();
            display.GetPlayer2Name();
            Console.WriteLine("New Game started");
        }






    }
}
