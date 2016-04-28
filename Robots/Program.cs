using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my robot gallery");
            Console.WriteLine("would you like to view my gallery? yes/no");
            string answer = Console.ReadLine();
            if (answer.Equals("yes"))
            {
                Console.WriteLine("Awesome:)");
                Robot_Gallery.Gallery();
            }
            else if (answer.Equals("no"))
            {
                Console.WriteLine("Thanks for stopping by:(");
            }
        }

    }
}
