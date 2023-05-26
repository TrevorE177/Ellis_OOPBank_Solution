using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// I guess this is more like a customer "doing" transactions separate from a bank teller otherwise transactions should probably be in the vault class.  But they're essentially the same whether they're here or there.

namespace Bank_Project
{
    public class Customer : IAccount
    {
        // Variables should be private
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

            Balance = cBalance + sBalance;
        }
                
        public void Deposit(decimal amount) // Is this technically duplicating money if I also always withdraw from both places?
        {
            if (amount > 0)
            {
                _checkingBalance += amount;
            }
            else if (amount <= 0)
            {
                Console.WriteLine(errorDMessage);
                throw new Exception("Wrong number input");
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0)
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
                else if (amount > (_checkingBalance + _savingsBalance - 10))
                {
                    throw new Exception("Balance is too low");
                }
            }
            else
            {
                throw new Exception("Please enter a number greater than zero");
            }
        }
    } 
}
