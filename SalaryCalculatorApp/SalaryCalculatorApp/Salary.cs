using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalculatorApp
{
    class Salary
    {
        public string name;
        public double basicSalary;
        public double houseRentPercent;
        public double medicalAllowancePercent;

        public double GetSalary()
        {
            return basicSalary + GetHouseAmount() + GetMedicalAmount();

        }

        public double GetMedicalAmount()
        {
            return (houseRentPercent*basicSalary)/100;
        }

        public double GetHouseAmount()
        {
            return (medicalAllowancePercent*basicSalary)/100;
        }
    }
}
