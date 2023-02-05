using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_problems
{
    internal class Program
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

        }
    }
}
