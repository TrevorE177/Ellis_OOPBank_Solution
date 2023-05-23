using Bank_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace OOPBank.Tests
{
    [TestClass]
    public class Program_Tests
    {
        [TestMethod]
        public void TestDepositSuccess() // CC of 1 but lots of traffic
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal deposit = 499M;
            decimal expected = 2499M;
            decimal result = c._checkingBalance + deposit;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Wrong number input")]
        public void TestNegativeDeposit()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal deposit = -50;
            c.Deposit(deposit);
        }

        [TestMethod]
        public void TestWithdrawLessThanChecking() // CC of 4
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 100;
            c.Withdraw(withdrawal);
        }

        [TestMethod]
        public void TestWithdrawGreaterThanChecking()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 2500;
            c.Withdraw(withdrawal);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Balance is too low")]
        public void TestWithdrawFail()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 10000;
            c.Withdraw(withdrawal);
        }
    }
}