using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas 8 (Pertemuan 11) - OOP & Collections";

            FixEmployee fixEmployee = new FixEmployee();
            fixEmployee.NIK = "123-234-345";
            fixEmployee.Name = "Michael Suyama";
            fixEmployee.MonthlySalary = 4000000;

            DailyEmployee dailyEmployee = new DailyEmployee();
            dailyEmployee.NIK = "123-321-346";
            dailyEmployee.Name = "Laura Callahan";
            dailyEmployee.TotalWorkingHours = 8;
            dailyEmployee.HourlyWages = 13000;

            Salesman salesman = new Salesman();
            salesman.NIK = "123-333-347";
            salesman.Name = "Andrew Fuller";
            salesman.SalesAmount = 30;
            salesman.Commission = 45000;

            List<Employee> listEmployee = new List<Employee>();
            listEmployee.Add(fixEmployee);
            listEmployee.Add(dailyEmployee);
            listEmployee.Add(salesman);

            Console.Clear();
            int listNumber = 1;
            foreach(Employee employee in listEmployee)
            {
                Console.WriteLine("{0}. NIK : {1}\t| Nama : {2}\t| Gaji : {3}", listNumber, employee.NIK, employee.Name, employee.Salary());
                listNumber++;
            }

            Console.ReadKey();
        }
    }
}
