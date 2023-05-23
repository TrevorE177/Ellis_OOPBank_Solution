using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal class Customer : IAccount
    {
        // should be private variables
        public decimal _checkingBalance;
        public decimal _savingsBalance;
        public string _memberName;

        public string errorDMessage = "Please enter a valid number...";
        public string errorWMessage = "Amount is larger than the sum of your accounts; please input a smaller number...";

        private decimal remainder = 0M;
        public decimal Balance { get; }

        public Customer(decimal cBalance, decimal sBalance, string memberName)
        {
            _checkingBalance = cBalance;

            _savingsBalance= sBalance;

            _memberName = memberName;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                _checkingBalance += amount;
            }
            else
            {
                Console.WriteLine(errorDMessage);  // should be an error exception, not just a message
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= _checkingBalance)
            {
                _checkingBalance -= amount;
            }
            else if (amount > _checkingBalance && amount <= (_checkingBalance + _savingsBalance - 10))
            {
                remainder = amount - _checkingBalance;
                _checkingBalance = 0;
                _savingsBalance -= remainder;
            }
        }
    } 
}
