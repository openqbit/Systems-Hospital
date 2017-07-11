using OpenQbit.Hospital.Common.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface ISalaryManager
    {

        bool RecoredSalary(Salary salary);
        bool EditSalary(Salary salary);
        bool RemoveSalary(Salary salary);
        List<Salary> GetAllSalaries();
        Salary FindSalary(Salary salary);
    }
}
