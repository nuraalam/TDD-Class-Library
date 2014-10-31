using System.Globalization;

namespace EmployeeSalaryLib
{
    public class Salary
    {
        public double BasicSalary { get; private set; }
        public double Convenyence { get; private set; }
        public double Medical { get; private set; }
        public double TotalSalary { get; private set; }

        private double increment;
        private int numberOfIncrement;

        public double IncrementInPercentages
        {
            set
            {
                numberOfIncrement++;
                increment = (value+100)/100;
                GetTotalSalary();
            }
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
      
        private double GetTotalSalary()
        {
            BasicSalary = BasicSalary * increment;
            Medical = Medical * increment;
            Convenyence = Convenyence * increment;
            return TotalSalary = BasicSalary+Medical+Convenyence;
        }

        public int GetNumberofIncrement()
        {
            return numberOfIncrement;
        }
    }
}