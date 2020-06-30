using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    public abstract class Employee
    {
        public string NIK { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public abstract double Salary();
    }
}
