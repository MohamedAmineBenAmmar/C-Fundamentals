using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class ListOfAnyType
    {
        public static int fibo(int item1, int item2, int index)
        {
            if (index > 0)
            {
                int newItem = item1 + item2;
                index--;
                return fibo(item2, newItem, index);
            } else { return item2; }
        }
        public static void explore()
        {
            int index = 18;
            int firstItem = 1;
            int secondItem = 1;

            int fiboItem = fibo(firstItem, secondItem, index);
            Console.WriteLine($"Fibo Item {index} is {fiboItem}");
        }
    }
}
