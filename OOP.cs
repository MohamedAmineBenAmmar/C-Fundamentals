using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class OOP
    {
        public static void explore()
        {
            // Initializing the object
            BankAccount account = new BankAccount("Kendra", 10000);
            Console.WriteLine(account);

            // Making few transactions
            account.MakeWithDrawal(120, DateTime.Now, "Hammock");
            account.MakeWithDrawal(500, DateTime.Now, "PC");
            account.MakeWithDrawal(1500, DateTime.Now, "BMW M8 Competition");
            Console.WriteLine(account);

            // Displaying the transactions history
            Console.WriteLine(account.GetAccountHistory());

            // Testing try catch statement
            try
            {
                account.MakeWithDrawal(500000000, DateTime.Now, "Hammock");
            }
            catch (InvalidOperationException e)
            {

                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

        }
    }
}
