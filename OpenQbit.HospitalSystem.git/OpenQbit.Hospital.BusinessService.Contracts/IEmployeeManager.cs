using OpenQbit.Hospital.Common.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IEmployeeManager
    {
        bool RecoredEmployee(Employee employee);
        bool EditEmployee(Employee employee);
        bool RemoveEmployee(Employee employee);
        List<Employee> GetAllEmployees();
        Employee FindEmployee(Employee employee);
    }
}
