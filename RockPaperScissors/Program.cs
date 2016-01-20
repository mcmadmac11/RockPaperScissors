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
            Player player = new Player();
            Display display = new Display();
            display.GetUserName();
            Console.WriteLine(display.GetUserName());

        }
    }
}
