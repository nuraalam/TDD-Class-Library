using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using EmployeeSalaryLib;
using NUnit.Framework;

namespace EmployeeSalaryTest
{
    [TestFixture]
    public class SalaryFixture
    {
        private Salary aSalary;

        [SetUp]
        public void Start()
        {
           aSalary = new Salary();
        }
        [Test]
        public void TotalSalaryZero()
        {          
            Assert.AreEqual(0,aSalary.TotalSalary,0.01);
        }

        [Test]
        public void Check_Total_6750_if_Basic_5000_Medical20p_Convenyence15p()
        {
            aSalary=new Salary(5000,20,15);
            Assert.AreEqual(6750,aSalary.TotalSalary,0.01);
        }
     
        [Test]
        public void Check_Basic_6000_if_Basic_5000_Medical20p_Convenyence15p_Increment20p()
        {
            aSalary = new Salary(5000, 20, 15);
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(6000, aSalary.BasicSalary, 0.01);
        }
        [Test]
        public void Check_Medical_1200_if_Basic_5000_Medical20p_Convenyence15p_Increment20p()
        {
            aSalary = new Salary(5000, 20, 15);
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(1200, aSalary.Medical, 0.01);
        }
        [Test]
        public void Check_Convenyence_900_if_Basic_5000_Medical20p_Convenyence15p_Increment20p()
        {
            aSalary = new Salary(5000, 20, 15);
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(900, aSalary.Convenyence, 0.01);
        }
        [Test]
        public void Check_Total_8100_if_Basic_5000_Medical20p_Convenyence15p_Increment20p()
        {
            aSalary = new Salary(5000, 20, 15);
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(8100, aSalary.TotalSalary, 0.01);
        }
        [Test]
        public void Check_NumberOfIncrement_is_1_if_Basic_5000_Medical20p_Convenyence15p_Increment20p()
        {
            aSalary = new Salary(5000, 20, 15);
            aSalary.IncrementInPercentages = 20;
            
            Assert.AreEqual(1, aSalary.GetNumberofIncrement());
        }
        [Test]
        public void Check_NumberOfIncrement_is_3_if_Basic_10000_Medical10p_Convenyence20p_Increment10p_15p_and_20p()
        {
            aSalary = new Salary(10000, 10, 20);
            aSalary.IncrementInPercentages = 10;
            aSalary.IncrementInPercentages = 15;
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(3, aSalary.GetNumberofIncrement());
        }
        [Test]
        public void Check_Basic_15180_if_Basic_10000_Medical10p_Convenyence20p_Increment10p_15p_and_20p()
        {
            aSalary = new Salary(10000, 10, 20);
            aSalary.IncrementInPercentages = 10;
            aSalary.IncrementInPercentages = 15;
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(15180, aSalary.BasicSalary,0.01);
        }
        [Test]
        public void Check_Medical_1518_if_Basic_10000_Medical10p_Convenyence20p_Increment10p_15p_and_20p()
        {
            aSalary = new Salary(10000, 10, 20);
            aSalary.IncrementInPercentages = 10;
            aSalary.IncrementInPercentages = 15;
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(1518, aSalary.Medical, 0.01);
        }
        [Test]
        public void Check_Convenyence_3036_if_Basic_10000_Medical10p_Convenyence20p_Increment10p_15p_and_20p()
        {
            aSalary = new Salary(10000, 10, 20);
            aSalary.IncrementInPercentages = 10;
            aSalary.IncrementInPercentages = 15;
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(3036, aSalary.Convenyence, 0.01);
        }
        [Test]
        public void Check_TotalSalary_19734_if_Basic_10000_Medical10p_Convenyence20p_Increment10p_15p_and_20p()
        {
            aSalary = new Salary(10000, 10, 20);
            aSalary.IncrementInPercentages = 10;
            aSalary.IncrementInPercentages = 15;
            aSalary.IncrementInPercentages = 20;
            Assert.AreEqual(19734, aSalary.TotalSalary, 0.01);
        }

        [TearDown]
        public void End()
        {
            aSalary = null;
        }
    }
}
