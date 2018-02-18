using BankTellerExercise.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            BankCustomer jake = new BankCustomer();
            BankCustomer hannaBanana = new BankCustomer();
            BankCustomer peasant = new BankCustomer();
            BankCustomer memeLord = new BankCustomer();

            jake.AddAccount(new CheckingAccount().Deposit(100));



        }
    }
}
