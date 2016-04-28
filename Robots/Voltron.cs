using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Voltron : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to Voltron.");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("*starts dancing*");
            else if (action.Equals("2"))
                Console.WriteLine("Powersmash");
            else if (action.Equals("3"))
                Console.WriteLine("Shoots arm at you");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }

}
