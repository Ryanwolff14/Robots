using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Wall_E : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to Wall-E");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("WAAAALLLEeee");
            else if (action.Equals("2"))
                Console.WriteLine("*watches romantic movie with you*");
            else if (action.Equals("3"))
                Console.WriteLine("*throws junk at you*");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }
}
