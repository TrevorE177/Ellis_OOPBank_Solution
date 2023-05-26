using Bank_Project;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Data;

// Missing 1 converage in Customer deposit and withdraw tests CANNOT figure out what to do to cover them... :(

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
        public void TestWithdrawIntoSavings() // Haven't been able to figure out how to test for both criteria in the if statement.  My 1 line not covered is "partially" covered.
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 2500;
            c.Withdraw(withdrawal);
            Assert.AreEqual(2500, c._savingsBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Balance is too low")]
        public void TestWithdrawFail()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal withdrawal = 10000;
            c.Withdraw(withdrawal);
            Assert.AreEqual(10000, c._checkingBalance);
        }

        // VAULT METHODS 

        [TestMethod]
        public void TestVaultDeposit() // (CC: 2)
        {
            Vault v = new Vault(1000000);
            decimal deposit = 499;
            decimal vaultBalance = 1000000;
            v.Deposit(deposit);
            Assert.AreEqual(vaultBalance + deposit, v.bankMoney);
        }

        [TestMethod]
        public void TestVaultWithdrawal() // (CC: 2)
        {
            Vault v = new Vault(1000000);
            decimal withdrawal = 499;
            decimal vaultBalance = 1000000;
            v.Withdraw(withdrawal);
            Assert.AreEqual(vaultBalance - withdrawal, v.bankMoney);
        }

        // SAVINGS (CC: 13)

        [TestMethod]
        public void TestSavingsBalance()
        {
            Savings s = new Savings();
            decimal _savingsBalance = 3000M;
            Assert.AreEqual(_savingsBalance, s.Balance);
        }

        [TestMethod]
        public void TestGetBalanceSavings()
        {
            Savings s = new Savings();
            decimal _savingsBalance = 3000M;
            s.getBalance();
            Assert.AreEqual(_savingsBalance, s.Balance);
        }

        // CHECKING (CC: 13)

        [TestMethod]
        public void TestCheckingBalance()
        {
            Checking c = new Checking();
            decimal _checkingBalance = 2000M;
            Assert.AreEqual(_checkingBalance, c.Balance);
        }

        [TestMethod]
        public void TestGetBalanceChecking()
        {
            Checking c = new Checking();
            decimal _checkingBalance = 2000M;
            c.getBalance();
            Assert.AreEqual(_checkingBalance, c.Balance);
        }

        // CUSTOMER GETBALANCE (CC: 1)

        [TestMethod]
        public void TestGetBalance()
        {
            Customer c = new Customer(2000, 3000, "Jimothy");
            decimal cTotal = 5000;
            Assert.AreEqual(cTotal, c.Balance);
        }
    }
}