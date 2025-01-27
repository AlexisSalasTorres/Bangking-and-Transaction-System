using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangking_and_Transaction_System
{
    internal class CheckingAccount : Account
    {
        private readonly decimal overdraftLimit;

        public CheckingAccount(string accountHolderName, decimal initialBalance, decimal overdraftLimit)
            : base(accountHolderName, overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;

        }
        public override void Withdraw(decimal amount)
        {
            if (amount > Balance + overdraftLimit)
            {
                Console.WriteLine("Withdrawal amount exceed overdraft limit .");
                return;

            }
            Balance -= amount;
            Console.WriteLine($" {amount:C} withdrawn. New Balance: {Balance:C}");

        }
    }
}
