using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class StringBasics
    {
        public static void explore()
        {
            // Example of string interpolation
            string str1 = "Hamma";
            string str2 = "Dali";
            Console.WriteLine($"{str1} and {str2} are da best");

            // String properties
            // - Length
            int str1Length = str1.Length;
            Console.WriteLine($"String length of {str1} is {str1Length}");

            // String functions
            // - TrimStart
            // - TrimEnd
            // - Trim
            // - Replace
            // - ToUpper
            // - ToLower
            // - Contains
            // - StartsWith
            // - EndsWith
            string strWithSpaces = "          aze     ";
            Console.WriteLine($"String with spaces: [{strWithSpaces}]");
            string strFiexedSpacesAtStart = strWithSpaces.TrimStart();
            string strFiexedSpacesAtEnd = strWithSpaces.TrimEnd();
            string strFiexedSpacesFully= strWithSpaces.Trim();
            Console.WriteLine("Removed spaces");
            Console.WriteLine($"Start: [{strFiexedSpacesAtStart}]");
            Console.WriteLine($"End: [{strFiexedSpacesAtEnd}]");
            Console.WriteLine($"Fully: [{strFiexedSpacesFully}]");

            Console.WriteLine("Before replace" + str1);
            Console.WriteLine("After replace" + str1.Replace("Hamma", "Super Hamma"));

            Console.WriteLine("Testing upper and lower functions");
            Console.WriteLine(str1.ToUpper());
            Console.WriteLine(str1.ToLower());

            string soundLyrics = "Ou 3al bouheli ya ma 3al bouheli yaaaaaa";
            bool flag =  soundLyrics.Contains("bouheli");
            Console.WriteLine("String existance test flag: " + flag);

            flag = soundLyrics.StartsWith("Wiiiiwouuuu");
            Console.WriteLine("String StartsWith: " + flag);

            flag = soundLyrics.EndsWith("yaaaaaa");
            Console.WriteLine("String EndsWith: " + flag);

        }
    }
}
