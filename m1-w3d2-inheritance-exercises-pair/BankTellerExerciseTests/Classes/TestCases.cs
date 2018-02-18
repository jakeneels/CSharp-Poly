using System;
using BankTellerExercise.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class TestCases
    {

        BankAccount bank = new BankAccount();
        CheckingAccount _checkingAccount = new CheckingAccount();
        SavingsAccount _savingsAccount = new SavingsAccount();

        [TestMethod]
        public void CheckingAccountDepositTest()
        {
            Assert.AreEqual(100, _checkingAccount.Deposit(100m));
        }
        [TestMethod]
        public void CheckingAccountWithdrawTest()
        {
            Assert.AreEqual(-110, _checkingAccount.Withdraw(100m), "attempted 100 withdraw");
            _checkingAccount.Deposit(110);
            Assert.AreEqual(0, _checkingAccount.Withdraw(0), "attempted 0 withdraw");
            Assert.AreEqual(-109, _checkingAccount.Withdraw(99), "attempted 99 withdraw");
            _checkingAccount.Deposit(109);
            Assert.AreEqual(0, _checkingAccount.Withdraw(100.01m), "attempted 100.01 withdraw");
            Assert.AreEqual(0, _checkingAccount.Withdraw(-0.01m), "attempted negative withdraw");
        }
        [TestMethod]
        public void SavingsAccountWithdrawTest()
        {
            Assert.AreEqual(-142, _savingsAccount.Withdraw(140m));
            _savingsAccount.Deposit(142);
            Assert.AreEqual(-102, _savingsAccount.Withdraw(100m));

           
        }
    }
}
