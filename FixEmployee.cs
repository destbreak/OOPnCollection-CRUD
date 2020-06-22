using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    class FixEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double Salary()
        {
            return MonthlySalary;
        }
    }
}
