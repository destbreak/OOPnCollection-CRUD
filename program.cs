using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPnCollection
{
    class Program
    {
        public static void Menu() {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t  PILIH MENU");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. Input Data Karyawan");
            Console.WriteLine("2. Delete Data Karyawan");
            Console.WriteLine("3. Print Data Karyawan");
            Console.WriteLine("4. Keluar");
            Console.WriteLine();
            Console.Write("Nomor Menu [1..4] : ");
        }

        public static void InputError()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("    INPUT TIDAK TERDETEKSI");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        public static void AddNotification()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("     TAMBAH DATA KARYAWAN");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        public static void AddSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t INPUT SUKSES");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        public static void DeleteNotification()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("     DELETE DATA KARYAWAN");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        public static void DeleteSuccess()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tDELETE SUKSES");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        public static void DeleteFailed()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t DELETE GAGAL");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        public static void PrintNotification()
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine("\t LIST KARYAWAN");
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }

        public static void PrintEmpty()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\tTIDAK ADA DATA");
            Console.WriteLine("------------------------------");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.Title = "Tugas 9 (Pertemuan 12) - OOP & Collections with CRUD";

            int menu = 1;
            int choice;
            int listNumber;

            List<Employee> listEmployee = new List<Employee>();

            do
            {
                Menu();
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                      AddNotification();
                      Console.Write("Jenis Karyawan [1. Karyawan Tetap | 2. Karyawan Harian | 3. Sales] : ");
                      choice = Convert.ToInt32(Console.ReadLine());
                      switch(choice)
                      {
                          case 1:
                            FixEmployee fixEmployee = new FixEmployee();
                            fixEmployee.Type = "Karyawan Tetap";

                            AddNotification();
                            Console.WriteLine("Jenis Karyawan : {0}", fixEmployee.Type);
                            Console.Write("NIK            : ");
                            fixEmployee.NIK = Console.ReadLine();
                            Console.Write("Nama           : ");
                            fixEmployee.Name = Console.ReadLine();
                            Console.Write("Gaji Bulanan   : ");
                            fixEmployee.MonthlySalary = Convert.ToDouble(Console.ReadLine());
                            AddSuccess();

                            listEmployee.Add(fixEmployee);
                            break;
                          case 2:
                            DailyEmployee dailyEmployee = new DailyEmployee();
                            dailyEmployee.Type = "Karyawan Harian";

                            AddNotification();
                            Console.WriteLine("Jenis Karyawan   : {0}", dailyEmployee.Type);
                            Console.Write("NIK              : ");
                            dailyEmployee.NIK = Console.ReadLine();
                            Console.Write("Nama             : ");
                            dailyEmployee.Name = Console.ReadLine();
                            Console.Write("Jumlah Jam Kerja : ");
                            dailyEmployee.TotalWorkingHours = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Upah per Jam     : ");
                            dailyEmployee.HourlyWages = Convert.ToDouble(Console.ReadLine());
                            AddSuccess();

                            listEmployee.Add(dailyEmployee);
                            break;
                          case 3:
                            Salesman salesman = new Salesman();
                            salesman.Type = "Salesman";

                            AddNotification();
                            Console.WriteLine("Jenis Karyawan   : {0}", salesman.Type);
                            Console.Write("NIK              : ");
                            salesman.NIK = Console.ReadLine();
                            Console.Write("Nama             : ");
                            salesman.Name = Console.ReadLine();
                            Console.Write("Jumlah Penjualan : ");
                            salesman.SalesAmount = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Komisi           : ");
                            salesman.Commission = Convert.ToDouble(Console.ReadLine());
                            AddSuccess();

                            listEmployee.Add(salesman);
                            break;
                          default:
                            InputError();
                            break;
                      }
                      break;
                    case 2:
                      string NIK;
                      int state = -1;
                      int stateNumber = -1;

                      DeleteNotification();
                      listNumber = 0;
                      foreach(Employee employee in listEmployee)
                      {
                          listNumber++;
                          Console.WriteLine("{0}. NIK : {1}\t| Nama : {2}\t| Jenis : {3}\t| Gaji : {4}", listNumber, employee.NIK, employee.Name, employee.Type, employee.Salary());
                      }
                      if(listNumber == 0)
                      {
                          PrintEmpty();
                          break;
                      }

                      Console.WriteLine();
                      Console.Write("NIK : ");
                      NIK = Console.ReadLine();
                      foreach(Employee employee in listEmployee)
                      {
                          stateNumber++;
                          if(employee.NIK == NIK)
                          {
                              state = stateNumber;
                          }
                      }

                      if(state != -1)
                      {
                          listEmployee.RemoveAt(state);
                          DeleteSuccess();
                      }
                      else
                      {
                          DeleteFailed();
                      }
                      break;
                    case 3:
                      PrintNotification();
                      listNumber = 0;
                      foreach(Employee employee in listEmployee)
                      {
                          listNumber++;
                          Console.WriteLine("{0}. NIK : {1}\t| Nama : {2}\t| Jenis : {3}\t| Gaji : {4}", listNumber, employee.NIK, employee.Name, employee.Type, employee.Salary());
                      }

                      if(listNumber == 0)
                      {
                          PrintEmpty();
                          break;
                      }
                      Console.ReadKey();
                      break;
                    case 4:
                      menu = 0;
                      break;
                    default:
                      InputError();
                      break;
                }
            }
            while(menu == 1);
        }
    }
}
