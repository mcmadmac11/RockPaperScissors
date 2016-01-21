using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {
        string playerName;   
        int Score = 0;
        List<int> HighScore = new List<int>();

        public Player()
        {           
            Score = 0;           
        }

        
    }
}
