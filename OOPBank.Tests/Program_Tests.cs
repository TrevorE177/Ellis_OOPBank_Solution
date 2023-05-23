using Bank_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace OOPBank.Tests
{
    [TestClass]
    public class Program_Tests
    {
        // DEPOSIT TESTS (CC: 1)

        [TestMethod]
        public void TestDepositSuccess()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal deposit = 499M;
            decimal balance = 2000;
            c.Deposit(deposit);
            Assert.AreEqual(balance + deposit, c._checkingBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Wrong number input")]
        public void TestNegativeDeposit()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal deposit = -50;
            c.Deposit(deposit);
        }

        // WITHDRAW TESTS (CC: 4)

        [TestMethod]
        public void TestWithdrawLessThanChecking()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 100;
            decimal balance = 2000;
            c.Withdraw(withdrawal);
            Assert.AreEqual(balance - withdrawal, c._checkingBalance);
        }

        [TestMethod]
        public void TestWithdrawCheckingEmpty()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 2500;
            c.Withdraw(withdrawal);
            Assert.AreEqual(0, c._checkingBalance);
        }

        [TestMethod]
        public void TestWithdrawIntoSavings()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 2500;
            c.Withdraw(withdrawal);
            Assert.AreEqual(2500, c._savingsBalance);
        }

        [TestMethod]
        public void TestWithdrawRemainderTen()
        {

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