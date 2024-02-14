using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class HelloWorld
    {
        public static void explore()
        {
            // Display message to the console
            Console.WriteLine("Hama is da best");

            // Reading user input
            Console.WriteLine("Type a message");
            Console.ReadLine();

            // String concatenation
            string str = "Hamma Is Da Best";
            Console.WriteLine("Message: " + str);

            // String interpolation
            Console.WriteLine($"YOOOO {str}");
        }
    }
}
