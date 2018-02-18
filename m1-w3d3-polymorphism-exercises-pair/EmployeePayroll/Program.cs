using EmployeePayroll.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> Google = new List<IWorker>();
            List<IWorker> IBM = new List<IWorker>();


            Google.Add(new SalaryWorker(52000, "Jake", "Neels"));
            Google.Add(new HourlyWorker(100, "Hanna", "Smith"));
            Google.Add(new VolunteerWorker("Gary", "Winth"));

            PrintEmployees(Google);
            Console.ReadKey();
        }

        static void PrintEmployees(List<IWorker> company)
        {
            Random jake = new Random();
            Console.WriteLine("Employee \t\t Hours Worked \t\t Pay");
            int totalHoursWorked = 0;
            double totalPay = 0;

            foreach (var worker in company)
            {
                int hoursWorked = jake.Next(60);
                Console.WriteLine(
                    $"{worker.LastName}, {worker.FirstName}" +
                    $" \t\t {hoursWorked}" +
                    $" \t\t\t {formatMoney(worker.CalculateWeeklyPay(hoursWorked))}");
                totalHoursWorked += hoursWorked;
                totalPay += worker.CalculateWeeklyPay(hoursWorked);
            }
            Console.WriteLine($"\nTotal Hours: {totalHoursWorked} ");
            Console.WriteLine($"Total Pay:   {formatMoney(totalPay)} ");

        }

        static string formatMoney(double pay) => String.Format("${0:0.00}", pay.ToString());



    }
}
