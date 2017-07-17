using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.opd;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class DoctorManager : IDoctorManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  DoctorManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllDoctors()
        {
            throw new NotImplementedException();
        }

        public bool RecoredDoctor(Doctor doctor)
        {
            _log.LogError("");

            return _repository.Create<Doctor>(doctor);
        }

        public bool RemoveDoctor(Doctor doctor)
        {
            _log.LogError("");

            return _repository.Delete<Doctor>(doctor);
        }

        public Doctor SearchDoctors(string doctorID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataDoctor(Doctor doctor)
        {
            _log.LogError("");

            return _repository.Update<Doctor>(doctor);
        }
    }
}
