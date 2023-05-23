using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace OOPBank.Tests
{
    [TestClass]
    public class Program_Tests
    {
        Customer c = new Customer(); // why no woooooork

        [TestMethod]
        public void TestDepositSuccess() // CC of 1 but lots of traffic
        {
            decimal deposit = 499M;
            decimal expected = 2499M;
            decimal result = c._checkingBalance + deposit;
            Assert.AreEqual(expected, result);
        }

        public void TestNegativeDeposit()
        {
            Exception expectedException = null;
            try
            {
                c.Deposit(-50);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }

        public void TestWithdrawSuccess() // CC of 4
        {

        }

        public void TestWithdrawFail()
        {

        }

        public void TestPrintMenuSuccess() // CC of 8; this is too complex
        {

        }
        
        public void TestPrintMenuFail()
        {

        }
    }
}