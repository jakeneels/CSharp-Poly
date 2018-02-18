using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
    [TestClass]
    public class UnitTest1
    {

        VolunteerWorker _volunteerWorker = new VolunteerWorker("Gary", "Winthrope");
        SalaryWorker _salaryWorker = new SalaryWorker(52000, "Hanna", "Banana");
        HourlyWorker _hourlyWorker = new HourlyWorker(100, "Jake", "The Snake");

        [TestMethod]
        public void VolunteerCalculateWeeklyPay()
        {
            Assert.AreEqual(0, _volunteerWorker.CalculateWeeklyPay(500), "passed weeklyHours 500");
            Assert.AreEqual(0, _volunteerWorker.CalculateWeeklyPay(-500), "passed weeklyHours -500");
            Assert.AreEqual(0, _volunteerWorker.CalculateWeeklyPay(0), "passed weeklyHours 0");
        }
        [TestMethod]
        public void HourlyWorkerCalculateWeeklyPay()
        {
            Assert.AreEqual(900, _hourlyWorker.CalculateWeeklyPay(9), "passed weeklyHours 9");
            Assert.AreEqual(-900, _hourlyWorker.CalculateWeeklyPay(-9), "passed weeklyHours -9");
            Assert.AreEqual(500, _hourlyWorker.CalculateWeeklyPay(5), "passed weeklyHours 5");

        }
        [TestMethod]
        public void SalaryWorkerCalculateWeeklyPay()
        {
            Assert.AreEqual(1000, _salaryWorker.CalculateWeeklyPay(52));
            Assert.AreEqual(1000, _salaryWorker.CalculateWeeklyPay(-52));
            Assert.AreEqual(1000, _salaryWorker.CalculateWeeklyPay(0));
        }
    }
}

