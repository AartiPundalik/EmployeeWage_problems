using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage_problems
{
    public interface MultiplecompaniesInterface
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void ComputeEmpWage();
        int ComputeEmpWage(AbilityToManageEmp companyEmpWage);
    }
}
    

