using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    class DailyEmployee : Employee
    {
        public double TotalWorkingHours { get; set; }
        public double HourlyWages { get; set; }
        public override double Salary()
        {
            return HourlyWages * TotalWorkingHours;
        }
    }
}
