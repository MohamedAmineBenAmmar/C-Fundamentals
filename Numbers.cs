// Using statement is used to import libraries
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Numbers
    {
        public static void explore()
        {
            // Working with ints
            int a = 5;
            int b = 5;
            int c = a + b;
            Console.WriteLine(c);

            // Note: When working with numbers we keep the same priority rules from math classes

            // Integer precision
            int a2 = 5;
            int b2 = 2;
            int c2 = a2 / b2;
            int d2 = a2 % b2;
            Console.WriteLine($"Dividing a2 = {a2} by b2 = {b2} = c2 = {c2} with the remainder = {d2}");

            // C# has a maximum and minimum for int
            int max = int.MaxValue;
            int min = int.MinValue;

            Console.WriteLine($"Min number int in C# is {min} and Max number in C# is {max}");

            // Example of max int overflow
            int overFlowTest = max + 10;
            // We added 10 => A 1 will be consumed to comeback to the smallest int and then it become like: max + x = min + (x - 1)
            Console.WriteLine($"Number overflow test: {overFlowTest}");

            // Working with doubles
            double x = 5.0;
            double y = 2.0;
            Console.WriteLine($"Dividing a double {x} by a double {y} = {x / y}");
            double maxDouble = double.MaxValue;
            double minDouble = double.MinValue;
            Console.WriteLine($"Max double number = {maxDouble} and Min double number = {minDouble}");

            // Working with decimals: more precision + fixed point
            // There is a suffix called M that we add at the end that is going to give us more precision
            decimal dx1 = 1.0M;
            decimal dx2= 3.0M;
            double dTest = 1.0 / 3.0;
            Console.WriteLine($"Testing decimalls in C# dividing {dx1} by {dx2} = {dx1 / dx2}");
            Console.WriteLine($"Comparaison with doubles 1 / 3 = {dTest}");

            // Supported numerical types are:
            // int
            // long
            // short
            // decimal => more precision + fixed point 
            // double => Large
        }
    }
}
