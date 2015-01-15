using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SalaryCalculatorApp
{
   
    

    [TestFixture]
    class SalaryCalculatorFixture
    {
        Salary aSalary=new Salary();
        [SetUp]
        public void initializing()
        {
            aSalary=new Salary();
        }
        [Test]
        public void AccountTest()
        {
            Assert.AreEqual(0,0,0);
        }

        [Test]
        public void BasicSalaryTest()
        {
            aSalary.basicSalary = 1500;
            Assert.AreEqual(1500,aSalary.GetSalary()); 
        }
        [Test]
        public void SalaryWithHouseRentTest()
        {

            aSalary.basicSalary = 15000;
            aSalary.houseRentPercent = 20;
           


            Assert.AreEqual(18000, aSalary.GetSalary());
        }
        [Test]
        public void SalaryWithMedicalAllowanceTest()
        {

            aSalary.basicSalary = 15000;
            aSalary.medicalAllowancePercent = 10;


            Assert.AreEqual(16500, aSalary.GetSalary());
        }
        [Test]
        public void TotalSalaryTest()
        {

            aSalary.basicSalary = 15000;
            aSalary.houseRentPercent = 20;
            aSalary.medicalAllowancePercent = 10;
            
            
            Assert.AreEqual(19500,aSalary.GetSalary());
        }
    }
}
