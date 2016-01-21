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
        string UserName;
        public string GetUserName()
        {
            Console.WriteLine("Enter your User Name");
            this.UserName = Console.ReadLine();
            string savedUserName = UserName;
            return savedUserName;
            
        }
        

        
        public void StoreUserName()
        {

            MyFileWriter writeToFile = new MyFileWriter(UserName,2,2,15);
            
                          
        }

       

    }
}
