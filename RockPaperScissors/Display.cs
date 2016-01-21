using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Display 
    {
        public Display()
        {

        }
        string Name1;
        string Name2;
        public string GetPlayer1Name()
        {
            Console.WriteLine("Enter Player 1 Name");
            this.Name1 = Console.ReadLine();
            string Player1Name = Name1;
            return Player1Name;
            
        }

        public string GetPlayer2Name()
        {
            Console.WriteLine("Enter Player 2 Name");
            this.Name2 = Console.ReadLine();
            string Player2Name = Name2;
            return Player2Name;

        }



        public void StoreResults()
        {

            MyFileWriter writeToFile = new MyFileWriter(Name1,Name2,2,2,15);
            
                          
        }

       

    }
}
