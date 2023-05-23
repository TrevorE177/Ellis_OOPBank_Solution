using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Checking : IAccount
    {
        private static decimal _balance = 2000.00M;

        public decimal Balance
        {
            get { return _balance; }
        }

        public Checking()
        {
            
        }

        public decimal getBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
