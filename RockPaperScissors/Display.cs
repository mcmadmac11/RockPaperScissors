using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{

    public class Display        
    {

        public string player1Name;
        public string player2Name;

        public Display()
        {
            GetPlayer1Name();
            GetPlayer2Name();
        }
        public string GetPlayer1Name()
        {
            Console.WriteLine("Enter Player 1 Name");
            this.player1Name = Console.ReadLine();
            return player1Name;
            
        }

        public string GetPlayer2Name()
        {
            Console.WriteLine("Enter Player 2 Name");
            this.player2Name = Console.ReadLine();
            return player2Name;

        }


       

    }
}
