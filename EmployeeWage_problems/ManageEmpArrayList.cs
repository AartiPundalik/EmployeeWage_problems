using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_problems
{
    public class ManageEmpArrayList
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private List<AbilityToManageEmp> companyEmpWageList;

        public void ListEmpWage()
        {
            this.companyEmpWageList = new List<AbilityToManageEmp>();
        }
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            AbilityToManageEmp company2 = new AbilityToManageEmp(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            companyEmpWageList.Add(company2);
        }
        public void ComputeEmpWage()
        {
            foreach (var EmpWage in companyEmpWageList)
            {
                EmpWage.SetTotalEmpWage(ComputeEmpWage(EmpWage));
                Console.WriteLine(EmpWage.ToString());
            }
        }
        public int ComputeEmpWage(AbilityToManageEmp companyEmpWage)
        {

            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }
    }
}

