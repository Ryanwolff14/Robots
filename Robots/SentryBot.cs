using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class SentryBot : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to the Sentrybot Gallery");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("Locks on");
            else if (action.Equals("2"))
                Console.WriteLine("*Fires Machinegun*");
            else if (action.Equals("3"))
                Console.WriteLine("*scans area*");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }
}
