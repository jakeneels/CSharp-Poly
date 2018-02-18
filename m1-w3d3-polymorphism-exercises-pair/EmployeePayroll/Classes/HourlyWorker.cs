using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class HourlyWorker : IWorker
    {
        public string FirstName { get; }
        public string LastName { get; }
        public double HourlyRate { get;}

        public double CalculateWeeklyPay(int hoursWorked)
        {
            double pay = HourlyRate * hoursWorked;
            double overTime = hoursWorked - 40;
            if (overTime > 0)
                pay = pay + (HourlyRate * overTime * .5);
        
            return pay;
        }

        //Constructor

        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            HourlyRate = hourlyRate;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
