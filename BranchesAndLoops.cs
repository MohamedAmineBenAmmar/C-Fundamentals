using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class BranchesAndLoops
    {

        public static void challenge(int min, int max)
        {
            for (int i = min; i < max +1; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void explore()
        {
            // Play with branches
            // &&: and
            // ||: or

            int a = 10;
            int b = 5;

            bool condition = a + b > 20;
            Console.WriteLine("An and condition");
            if (condition)
            {
                Console.WriteLine("a + b > 20");
            } else
            {
                Console.WriteLine("Condition is not met");
            }

            condition = a == 5 || b == 5;
            Console.WriteLine("An or condition");
            if (condition)
            {
                Console.WriteLine("a == 5 || b == 5");
            }
            else
            {
                Console.WriteLine("Condition is not met");
            }

            // Play with loops
            // While
            // Do while
            // For

            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            do
            {
                Console.WriteLine("Counter = " + counter);
                counter++;
            } while (counter <= 20);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            Console.WriteLine("Going to run the challenge function");            
            challenge(10, 20);

        }
    }
}
