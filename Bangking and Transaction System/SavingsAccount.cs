using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangking_and_Transaction_System
{
    internal class SavingsAccount : Account
    {
        private bool hasWithdrawnToday = false;
        public SavingsAccount(string accountHolderName, decimal initialBalance)
            : base(accountHolderName, initialBalance) { }

        public override void Withdraw(decimal amount)
        {
            if (hasWithdrawnToday)
            {
                Console.WriteLine(" You can only withdraw once per day.");
                return;

            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            Balance -= amount;
            hasWithdrawnToday=true;
            Console.WriteLine($"{amount:C} withdrawn. New balance:{Balance:C}");

        }
    }
}
