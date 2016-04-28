using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class MisterGutsy : Robot
    {
        public static void Choices()

        {
            Console.WriteLine("Welcome to Mister Gutsy");
            Console.WriteLine("Press 1 through 3 to see its actions and q to quit");
            actions();
        }

        public static void actions()
        {
            string action = Console.ReadLine();
            if (action.Equals("1"))
                Console.WriteLine("Loop detected ERROR ERROR");
            else if (action.Equals("2"))
                Console.WriteLine("ready to die for your country?? you commie son of a bitch");
            else if (action.Equals("3"))
                Console.WriteLine("the gallery is proudly sponsored by general atomics");
            else if (action.Equals("q"))
                Robot_Gallery.Gallery();
            else
                Console.WriteLine("error");
            actions();
        }
    }
}
