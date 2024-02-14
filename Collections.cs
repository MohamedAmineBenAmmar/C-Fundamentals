using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class Collections
    {

        public static void display(List<string> names)
        {
            //Console.WriteLine("First way to loop over the collection names (foreach)");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Console.WriteLine("\nSecond way to loop over the collection names (for)");
            //// Collections has a property called Count to determine the number of items within the collection
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Console.WriteLine(names[i].ToUpper());
            //}
        }
        public static void explore()
        {
            // Play with collections
            // Collection creation
            var names = new List<string> { "Goku", "Ichigo", "Naruto", "Mario" };
            display(names);

            // Collection functions
            // Add
            // Remove
            // IndedxOf
            // Sort => it does the sort in place
            
            Console.WriteLine("Enter a name to add to the list");
            string input = Console.ReadLine();
            names.Add(input);

            Console.WriteLine("Visualizing the updated array");
            display(names);

            Console.WriteLine("Enter a name to remove to the list");
            input = Console.ReadLine();
            if (names.Contains(input))
            {
                names.Remove(input);
            }
            else
            {
                Console.WriteLine("Name entered is not found");
            }            


            Console.WriteLine("Visualizing the updated array");
            display(names);

            var index = names.IndexOf("Ichigo");
            Console.WriteLine($"Ichigo index is = {index}");

            Console.WriteLine("\nnames array before sort");
            display(names);

            names.Sort();

            Console.WriteLine("\nnames array after sort");
            display(names);


        }
    }
}
