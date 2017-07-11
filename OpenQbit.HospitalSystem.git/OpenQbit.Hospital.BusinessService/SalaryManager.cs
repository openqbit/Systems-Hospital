using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Management;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;

namespace OpenQbit.Hospital.BusinessService
{
    public class SalaryManager : ISalaryManager
    {
        private ILogger _log;
        private IRepository _repository;

        public SalaryManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool EditSalary(Salary salary)
        {
            _log.LogError("");
            return _repository.Update<Salary>(salary);
        }

        public Salary FindSalary(Salary salary)
        {
            _log.LogError("");
            return _repository.Find<Salary>(S => S.Id == salary.Id);
        }

        public List<Salary> GetAllSalaries()
        {
            _log.LogError("");
            return _repository.GetAll<Salary>();
        }

        public bool RecoredSalary(Salary salary)
        {
            _log.LogError("");
            return _repository.Create<Salary>(salary);
        }

        public bool RemoveSalary(Salary salary)
        {
            _log.LogError("");
            return _repository.Delete<Salary>(salary);
        }
    }
}
