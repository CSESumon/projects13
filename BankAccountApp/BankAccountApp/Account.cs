using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    class Account
    {
        public string AccountNo { set; get; }
        public double Balance { set; get; }

        public string OpeningDate { set; get; }

        public double Deposite(double amount)
        {
           return Balance += amount;
        }

        public string Withdraw(double amount)
        {
            if (Balance-amount>=0)
            {
                Balance -= amount;
                return "Money Withdraw";
            }

            else
            {
                return "Insufficient Balance";
            }  
          
        }
    }
}
