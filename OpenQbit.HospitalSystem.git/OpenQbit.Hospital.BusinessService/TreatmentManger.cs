using OpenQbit.Hospital.BusinessService.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Ward;

namespace OpenQbit.Hospital.BusinessService
{
    class TreatmentManger : ITreatmnetManager
    {
        private IRepository _repository;

        private ILogger _log;


        public TreatmentManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredTreatment(Treatment Treatment)
        {
            _log.LogError("");
            return _repository.Create<Treatment>(Treatment);
        }

        public bool EditTreatment(Treatment Treatment)
        {
            _log.LogError("");
            return _repository.Update<Treatment>(Treatment);
        }

        public bool DeleteTreatment(Treatment Treatment)
        {
            _log.LogError("");
            return _repository.Delete<Treatment>(Treatment);
        }

        public List<Treatment> GetAllTreatment()
        {
            _log.LogError("");
            return _repository.GetAll<Treatment>();
        }

        public Treatment FindTreatment(Treatment Treatment)
        {
            _log.LogError("");
            return _repository.Find<Treatment>(T=>T.ID==Treatment.ID);
        }

       
    }
}
