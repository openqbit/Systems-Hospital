using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface ISalaryManager
    {
        bool RecoredSalary(Salary order);
        bool EditSalary(Salary order);
        bool RemoveSalary(Salary order);
        List<Salary> GetAllSalary();
        Salary FindOrders(Salary order);
    }
}
