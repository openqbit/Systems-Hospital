using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Management;
using OpenQbit.Hospital.Common.Utils.Logs;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;

namespace OpenQbit.Hospital.BusinessService
{
    public class EmployeeManager:IEmployeeManager
    {
        private ILogger _log;
        private IRepository _repository;


        public EmployeeManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool EditEmployee(Employee employee)
        {
            _log.LogError("");
            return _repository.Update<Employee>(employee);
        }

        public Employee FindEmployee(Employee employee)
        {
            _log.LogError("");
            return _repository.Find<Employee>(E => E.Id == employee.Id);
        }

        public List<Employee> GetAllEmployees()
        {
            _log.LogError("");
            return _repository.GetAll<Employee>();
        }

        public bool RecoredEmployee(Employee employee)
        {
            _log.LogError("");
            return _repository.Create<Employee>(employee);
        }

        public bool RemoveEmployee(Employee employee)
        {
            _log.LogError("");
            return _repository.Delete<Employee>(employee);
        }

    }
}
