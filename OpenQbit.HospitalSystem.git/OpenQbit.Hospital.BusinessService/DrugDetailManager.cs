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
    public class DrugDetailManager : IDrugDetailManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  DrugDetailManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllDrugDetail()
        {
            throw new NotImplementedException();
        }

        public bool RecoredDrugDetail(DrugDetail drugDetail)
        {
            _log.LogError("");

            return _repository.Create<DrugDetail>(drugDetail);
        }

        public bool RemoveDrugDetail(DrugDetail drugDetail)
        {
            _log.LogError("");

            return _repository.Delete<DrugDetail>(drugDetail);
        }

        public DrugDetail SearchDrugDetail(string drugDetailID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataDrugDetail(DrugDetail drugDetail)
        {
            _log.LogError("");

            return _repository.Update<DrugDetail>(drugDetail);
        }
    }
}
