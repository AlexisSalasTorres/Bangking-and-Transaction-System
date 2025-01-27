using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangking_and_Transaction_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount(" Alexis", 500m);
            CheckingAccount checking = new CheckingAccount("Christine", 300m, 200m);

            Console.WriteLine("Savings Account:");
            savings.Deposit(200m);
            savings.Withdraw(100m);
            savings.Withdraw(50m);

            Console.WriteLine("\nChecking Account:");
            checking.Deposit(100m);
            checking.Withdraw(400m);
            checking.Withdraw(200m);

            Console.WriteLine($"\nSavings Account Balance: {savings.GetBalance():C}");
            Console.WriteLine($"Checking Account Balance: {checking.GetBalance():C}");
            Console.ReadLine();

        }
    }
}
