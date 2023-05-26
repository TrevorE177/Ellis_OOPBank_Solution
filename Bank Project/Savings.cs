using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    public class Savings
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

        // not sure what to do with these, doesn't make sense to test
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
