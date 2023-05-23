using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Savings
    {
        private static decimal _balance = 3000.00M;

        public decimal Balance
        {
            get { return _balance; }
        }

        public Savings()
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
