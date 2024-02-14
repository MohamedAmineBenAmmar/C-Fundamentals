using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Fundamentals
{
    public class BankAccount
    {
        // Declaring attributes

        // Explanation of the get and set
        // In C#, a property that is declared with a get accessor but no set accessor is considered a read-only property. 
        // This means that the property can only be read, 
        // and once its value is set (usually in the constructor or through some initialization logic), it cannot be modified.

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                // At first glance we can tell that the Balance is a decimal
                // but we can calculate it so this getter will become a bit
                // of a behavior
                decimal balance = 0;
                foreach (var transaction in this.allTransactions)
                {
                    balance += transaction.Amount;
                }

                return balance;

            }
        }

        private static int accountNumberSeed = 1234567890; // Shared between all instances of this class
        private List<Transaction> allTransactions = new List<Transaction>();

        // Constructor
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++; // Each new account will get new number
        }

        // Methods
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        public override string ToString()
        {
            return $"Account Number: {this.Number}, Owner: {this.Owner}, Balance: {this.Balance}";
        }

        // Working with string builder and exploring date functions
        public string GetAccountHistory()
        {
            var report = new StringBuilder();
            report.AppendLine("Date\tAmount\tNote");
            foreach (var transaction in allTransactions)
            {
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t{transaction.Notes}");
            }

            return report.ToString();
        }

    }
}
