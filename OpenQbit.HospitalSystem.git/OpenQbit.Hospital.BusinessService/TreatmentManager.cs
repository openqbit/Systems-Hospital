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
    public class TreatmentManager : ITreatmentManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  TreatmentManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public Array AllTreatment()
        {
            throw new NotImplementedException();
        }

        public bool RecoreRdecordsl(Treatment treatment)
        {
            _log.LogError("");

            return _repository.Create<Treatment>(treatment);
        }

        public bool RemoveTreatment(Treatment treatment)
        {
            _log.LogError("");

            return _repository.Delete<Treatment>(treatment);
        }

        public Treatment SearchTreatment(string recordID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataTreatment(Treatment treatment)
        {
            _log.LogError("");

            return _repository.Update<Treatment>(treatment);
        }
    }
}
