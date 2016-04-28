using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class MedicBot : Robot
    {
        public static void Choices()
        {
            Console.WriteLine("Welcome to the MedicBot");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("scanning patient");
            else if (action.Equals("2"))
                Console.WriteLine("goes rouge");
            else if (action.Equals("3"))
                Console.WriteLine("kills patient");
            else
                Console.WriteLine("error");
            actions();
        }
    }
}
