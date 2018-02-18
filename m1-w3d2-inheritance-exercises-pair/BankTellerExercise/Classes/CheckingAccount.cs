using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(){}
        public override decimal Withdraw(decimal amountToWithdraw)
        {
            if (Balance - amountToWithdraw < -100.00m)
            {
                return Balance;
            }
            else if (Balance - amountToWithdraw < 0.00m)
            {
                return base.Withdraw(amountToWithdraw + 10.00m);
            }
            else 
            {
                return base.Withdraw(amountToWithdraw);
            }
        }


    }
}
