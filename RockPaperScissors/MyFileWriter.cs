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
        static MyFileWriter()
        {

            TextWriter writeToFile = new StreamWriter("Rock_Paper_Scissors.txt", true);
            writeToFile.Write("Player: ");
            writeToFile.Write("Wins:  Losses:  ");
            writeToFile.WriteLine("High Score: ");
            Console.WriteLine("Writing to file...");
            writeToFile.Close();

        }
    }

}
