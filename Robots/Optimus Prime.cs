using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Optimus_Prime : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to Optimus Prime");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        { 
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("Autobots Rollout");
            else if (action.Equals("2"))
                Console.WriteLine("Shilabouf get down from there");
            else if (action.Equals("3"))
                Console.WriteLine("Pew Pew");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }
}