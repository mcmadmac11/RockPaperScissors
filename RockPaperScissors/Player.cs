using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {

        public string playerName;   
        public int score = 0;
        public int wins = 0;
        public int losses = 0;

        public List<int> highScore = new List<int>() { 0 };

        public Player(string PlayerName,int Score,List<int> HighScore, int Wins, int Losses)
        {
            this.playerName = PlayerName;
            this.score = Score;
            this.highScore = HighScore;
            this.wins = Wins;
            this.losses = Losses;
        }

        
    }
}
