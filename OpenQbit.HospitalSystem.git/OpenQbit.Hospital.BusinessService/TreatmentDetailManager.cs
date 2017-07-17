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
    public class TreatmentDetailManager : ITreatmentDetailManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public  TreatmentDetailManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllTreatmentDetail()
        {
            throw new NotImplementedException();
        }

        public bool RecoredTreatmentDetail(TreatmentDetail treatmentDetail)
        {
            _log.LogError("");

            return _repository.Create<TreatmentDetail>(treatmentDetail);
        }

        public bool RemoveTreatmentDetail(TreatmentDetail treatmentDetail)
        {
            _log.LogError("");

            return _repository.Delete<TreatmentDetail>(treatmentDetail);
        }

        public TreatmentDetail SearchTreatmentDetail(string TreatmentDetailID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataTreatmentDetail(TreatmentDetail treatmentDetail)
        {
            _log.LogError("");

            return _repository.Update<TreatmentDetail>(treatmentDetail);
        }
    }
}
