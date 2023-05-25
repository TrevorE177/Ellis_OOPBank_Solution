using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Project
{
    internal interface IVault
    {
        decimal bankMoney { get; set; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
