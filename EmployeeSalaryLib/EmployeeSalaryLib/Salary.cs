using System.Globalization;

namespace EmployeeSalaryLib
{
    public class Salary
    {
        public double BasicSalary { get; private set; }
        public double Convenyence { get; private set; }
        public double Medical { get; private set; }
        public double TotalSalary { get; private set; }
        public int NumberOfIncrement { get; private set; }

        private double increment;       
        public void IncrementInPercentage(double incrementInPercentage)
        {
            NumberOfIncrement++;
            increment = (incrementInPercentage+100)/100;
            BasicSalary = BasicSalary * increment;
            Medical = Medical * increment;
            Convenyence = Convenyence * increment;
            TotalSalary = BasicSalary + Medical + Convenyence;

        }
        public Salary(double basic, double medicalPercentagesOfBasic, double convenyencePercentagesOfBasic)
        {
            BasicSalary = basic;
            Convenyence = convenyencePercentagesOfBasic*basic/100;
            Medical = medicalPercentagesOfBasic*basic/100;
            TotalSalary = BasicSalary + Convenyence + Medical;
        }

        public Salary()
        {
          
        }     
    }
}