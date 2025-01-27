using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangking_and_Transaction_System
{
    internal class BankingSystem
    {

    }
        public interface IAccount
    {
       
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        decimal GetBalance();
   
          }

       }


