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

            List<int> highScore = new List<int>()
            { 0 };
            Display display = new Display();

            string p1Name = display.player1Name;
            string p2Name = display.player2Name;
            Player player1 = new Player(p1Name, 0, highScore,0,0);
            Player player2 = new Player(p2Name, 0, highScore, 0, 0);

            MyFileWriter fileWriter = new MyFileWriter("Rock_Paper_Scissors.txt");
            fileWriter.WriteToFile(player1);
            fileWriter.WriteToFile(player2);        


            
            




            
            
            
            
            
            

        }
    }
}
