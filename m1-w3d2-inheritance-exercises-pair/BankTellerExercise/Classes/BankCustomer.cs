using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankCustomer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount> Accounts { get; }
        public bool IsVip { get; set; }

        //method
        public void AddAccount( BankAccount newAccount)
        {
            Accounts.Add(newAccount);
        }
        public void VIPCheck(BankCustomer customer)
        {
            decimal totalBalance = 0;
            foreach (var account in Accounts)
            {
                totalBalance += account.Balance;
            }
            IsVip = (totalBalance >= 25000) ? true : false; 
        }
    }
}
