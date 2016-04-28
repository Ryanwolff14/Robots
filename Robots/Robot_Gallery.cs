using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots
{
    public class Robot_Gallery
    {
        public static void Gallery()
        {
            Console.WriteLine("the robots we currently have in the gallery are>");
            string[] sarray = { "1 = Bender, ", "2 = LaserTurret, ", "3 = MedicBot, ", "4 = MisterGutsy, ", "5 = Optimus Prime, ", "6 = R2-D2, ", "7 = SentryBot, ", "8 = Voltron, ", "9 = Walle-E, " };
            string message = String.Join("", sarray);
            Console.WriteLine("Which one would you like to view?: {0}", message);
            string choice = Console.ReadLine();
            if (choice.Equals("1"))
            {
                Console.WriteLine("good choice");
                Bender.Choices();
            }
            else if (choice.Equals("2"))
            {
                Console.WriteLine("good choice");
                LaserTurret.Choices();
            }
            else if (choice.Equals("3"))
            {
                Console.WriteLine("good choice");
                MedicBot.Choices();
            }
            else if (choice.Equals("4"))
            {
                Console.WriteLine("good choice");
                MisterGutsy.Choices();
            }
            else if (choice.Equals("5"))
            {
                Console.WriteLine("good choice");
                Optimus_Prime.Choices();
            }
            else if (choice.Equals("6"))
            {
                Console.WriteLine("good choice");
                R2_D2.Choices();
            }
            else if (choice.Equals("7"))
            {
                Console.WriteLine("good choice");
                SentryBot.Choices();
            }
            else if (choice.Equals("8"))
            {
                Console.WriteLine("good choice");
                Voltron.Choices();
            }
            else if (choice.Equals("9"))
            {
                Console.WriteLine("good choice");
                Wall_E.Choices();
            }
            else
                Console.WriteLine("ERROR");
            Robot_Gallery.Gallery();
        }
    }
}
