using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount() { }
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance  < 150m)
            {
                return base.Withdraw(amountToWithdraw + 2m);
            }
            else if (amountToWithdraw > Balance)
            {
                return Balance;
            }
            else
            {
                return base.Withdraw(amountToWithdraw);
            }
        }
    }
}
