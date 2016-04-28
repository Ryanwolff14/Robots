using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Bender : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to the Benderbot");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("Kiss my Shiney Metal Ass");
            else if (action.Equals("2"))
                Console.WriteLine("*steals your wallet*");
            else if (action.Equals("3"))
                Console.WriteLine("*bends Gurter*");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }
}
