using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lecture1_BankAccount;     // Add new reference to Lecture1_BankAccount class & use namespace

namespace BankAccountTests
{
    [TestClass]
    public class DebitTests
    {
        [TestMethod]
        public void DebitSubtractedFromBalance()
        {
            // Arrange
            BankAccount account = new BankAccount();    // create object
            account.Balance = 100;      // initialize variables

            // Act
            account.Debit(20);      // action to be performed

            // Assert
            Assert.AreEqual(80/*expected*/, account.Balance/*actual*/, "My Message!");     // test result
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]    // attribute
        public void DebitThrowsArgumentOutOfRangeException()    // Testing a negative behavior
        {
            // Arrange
            BankAccount account = new BankAccount();   
            account.Balance = 100;      

            // Act
            account.Debit(0);      
            
            // Assert - implied by 'ExpectedException' attribute
        }
    }
}
