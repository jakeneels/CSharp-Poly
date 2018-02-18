using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class SalaryWorker : IWorker
    {
        public string FirstName { get; }

        public string LastName { get; }

        public double CalculateWeeklyPay(int hoursWorked)

        {
            return AnnualSalary / 52;
        }
        public double AnnualSalary { get; }

        //constructor
        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            AnnualSalary = annualSalary;
            FirstName = firstName;
            LastName = lastName;

        }

    }
}
