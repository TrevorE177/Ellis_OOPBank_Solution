using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    // I feel like these classes should be internal but I can't figure out how to test them without setting them as public
    public class Vault : IVault
    {
        public decimal bankMoney { get; set; }
        public static decimal _bankMoney = 1000000M;

        public Vault(decimal BankMoney)
        {
            BankMoney = _bankMoney;
            bankMoney= BankMoney;
        }

        public void Deposit(decimal amount)
        {
            bankMoney += amount;
        }

        public void Withdraw(decimal amount)
        {
            bankMoney -= amount;
        }
    }
}
