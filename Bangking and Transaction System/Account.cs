using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangking_and_Transaction_System
{
    internal abstract class Account : IAccount
    {
        public string AccounntHolderName { get; set; }
        public decimal Balance { get; set; }

        public Account(string accounntHolderName, decimal InitialBalance)
        {
            AccounntHolderName = accounntHolderName;
            Balance = InitialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($" {amount:C} deposited. New balance: {Balance:C}");
        }
        public decimal GetBalance()
        {
            return Balance;
        }
        public abstract void Withdraw (decimal amount);
    }

}
