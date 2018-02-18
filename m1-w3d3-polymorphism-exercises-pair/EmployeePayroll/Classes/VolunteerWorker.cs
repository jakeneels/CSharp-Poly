using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class VolunteerWorker : IWorker
    {
        public string FirstName { get; }

        public string LastName { get; }

        public double CalculateWeeklyPay(int hoursWorked)
        {
           return hoursWorked * 0;
        }

        //COnstructor
        public VolunteerWorker(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }
    }
}
