using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Display
    {
        public string GetUserName()
        {
            Console.WriteLine("Enter your User Name");
            string UserName = Console.ReadLine();
            string displayUserName = UserName;
            return displayUserName;
        }

       

    }
}
