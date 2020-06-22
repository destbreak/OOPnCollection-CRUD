using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    class Salesman : Employee
    {
        public double SalesAmount { get; set; }
        public double Commission { get; set; }
        public override double Salary()
        {
            return Commission * SalesAmount;
        }
    }
}
