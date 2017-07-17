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
    public class DrugManager : IDrugManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public DrugManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }


        public Array AllDrug()
        {
            throw new NotImplementedException();
        }

        public bool RecoredDrug(Drug drug)
        {
            _log.LogError("");

            return _repository.Create<Drug>(drug);
        }

        public bool RemoveDrug(Drug drug) 
        {
            _log.LogError("");

            return _repository.Delete<Drug>(drug);
        }

        public Drug Search(string drugID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataDrug(Drug drug)
        {
            _log.LogError("");

            return _repository.Update<Drug>(drug);
        }
    }
}
