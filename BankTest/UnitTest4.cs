using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            // arrange  
            double beginningBalance = 11.99;
            double creditAmount = 4.55;
            double expected = 16.54;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.Credit(creditAmount);

            // assert  
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}
