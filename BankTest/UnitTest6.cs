using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;

namespace BankTest
{
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Credit_WhenFrozen_ShouldThrowException()
        {

            // arrange  
            double beginningBalance = 11.99;
            double creditAmount = 100.00;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act  
            account.FreezingCold();
            account.Credit(creditAmount);
            
            // assert is handled by ExpectedException  
            try
            {
                account.Credit(creditAmount);
            }
            catch (Exception e)
            {
                // assert  
                StringAssert.Contains(e.Message, "Account frozen");
                return;
            }
            Assert.Fail("No exception was thrown.");
        }
    }
}
