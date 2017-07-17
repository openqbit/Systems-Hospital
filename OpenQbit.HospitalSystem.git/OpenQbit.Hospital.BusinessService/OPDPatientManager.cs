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
    public class OPDPatientManager : IOPDPatientManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  OPDPatientManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllOPDPatient()
        {
            throw new NotImplementedException();
        }

        public bool RecoredOPDPatient(OPDPatient OPDPatient)
        {
            _log.LogError("");

            return _repository.Create<OPDPatient>(OPDPatient);
        }

        public bool RemoveOPDPatient(OPDPatient OPDPatient)
        {
            _log.LogError("");

            return _repository.Delete<OPDPatient>(OPDPatient);
        }

        public OPDPatient SearchOPDPatient(string OPDPatientID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataOPDPatient(OPDPatient OPDPatient)
        {
            _log.LogError("");

            return _repository.Update<OPDPatient>(OPDPatient);
        }
    }
}
