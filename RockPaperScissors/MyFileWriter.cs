using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RockPaperScissors
{
     public class MyFileWriter
    {
        string name1;
        string name2;
        int wins;
        int losses;
        int highScore;
        public MyFileWriter(string name1, string name2, int wins, int losses, int highScore)
        {

            TextWriter writeToFile = new StreamWriter("Rock_Paper_Scissors.txt", true);
            writeToFile.Write("Player:{0}", name1);
            writeToFile.Write("Player:{0}", name2);
            writeToFile.Write("Wins: {0} Losses:{1} ",wins.ToString(), losses.ToString());
            writeToFile.WriteLine("High Score: {0}",highScore.ToString());
            Console.WriteLine("Writing to file...");
            writeToFile.Close();
            
        }
    }

}
