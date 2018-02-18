using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        //props
        public string AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        //constructor
        public BankAccount()
            {
            Balance = 0;
            }

        //methods
        public decimal Deposit(decimal amountToDeposit) => Balance += amountToDeposit;
        public virtual decimal Withdraw(decimal amountToWithdraw) =>(amountToWithdraw > 0) ? Balance -= amountToWithdraw : Balance;
        private void Transfer(BankAccount destinationAccount, decimal transferAmount)
        {
            Withdraw(transferAmount);
            destinationAccount.Deposit(transferAmount);
        }
    }
}
