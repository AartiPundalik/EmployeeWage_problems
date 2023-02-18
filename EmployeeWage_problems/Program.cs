using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Empcheck empcheck = new Empcheck();
            Empcheck.Attendance();
            Console.ReadLine();
            UC2 emppcheck = new UC2();
            UC2.empcheck();
            Console.ReadLine();
            UC3 empcheckk = new UC3();
            UC3.PartTime();
            Console.ReadLine();
            SwitchCase Switch = new SwitchCase();
            SwitchCase.Switch();
            Console.ReadLine();
            MonthWage MonthlyWage = new MonthWage();
            MonthWage.MonthlyWage();
            Console.ReadLine();
            HoursDaysTotal HoursDaysOfMonth = new HoursDaysTotal(); 
            HoursDaysTotal.HoursDaysOfMonth();
            Console.ReadLine();
            Refactor EmployeeWage = new Refactor();
            Refactor.EmployeeWage();
            Console.ReadLine();
            MultipleCompanies computeEmpWage= new MultipleCompanies();
            MultipleCompanies.computeWage("BigBazaar", 20, 50, 40);
            MultipleCompanies.computeWage("StarBazaar", 30, 10, 80);
            Console.ReadLine();
            SaveTheTotal bigbazaar = new SaveTheTotal("bigbazaar", 20, 2, 10);
            SaveTheTotal starbazaar = new SaveTheTotal("starbazaar", 10, 4, 20);
            bigbazaar.Attendance();
            Console.WriteLine(bigbazaar.ToString());
            starbazaar.Attendance();
            Console.WriteLine(starbazaar.ToString());
            Console.ReadKey();







        }
    }
}
