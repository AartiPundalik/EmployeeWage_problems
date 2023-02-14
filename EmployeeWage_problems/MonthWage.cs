using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_problems
{
    public  class MonthWage
    {
        const int Emp_Rate_Per_Hour = 20;
        const int Num_Of_Working_Days = 20;

        public static void MonthlyWage()
        {

            int Empwage;
            int Emphours;
            int TotalEmpwage = 0;

            for (int day = 0; day < Num_Of_Working_Days; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);


                switch (empcheck)
                {
                    case 1:
                        Emphours = 8;
                        break;

                    case 2:
                        Emphours = 4;
                        break;

                    default:
                        Emphours = 0;
                        break;
                }

                Empwage = Emphours * Emp_Rate_Per_Hour;
                TotalEmpwage = TotalEmpwage + Empwage;
                Console.WriteLine("Daily employee wage is : " + Empwage);

            }
            Console.WriteLine("Total Emp wage : " + TotalEmpwage);
        }
    }
}


