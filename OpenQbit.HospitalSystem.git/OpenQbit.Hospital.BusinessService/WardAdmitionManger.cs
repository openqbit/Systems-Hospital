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
    class WardAdmitionManger :  IWardAdmitionManeger
    {
        private IRepository _repository;

        private ILogger _log;


        public WardAdmitionManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredWardAdmition(WardAdmition WardAdmition)
        {
            _log.LogError("");
            return _repository.Create<WardAdmition>(WardAdmition);
        }

        public bool EditWardAdmition(WardAdmition WardAdmition)
        {
            _log.LogError("");
            return _repository.Update<WardAdmition>(WardAdmition);
        }

        public bool DeleteWardAdmition(WardAdmition WardAdmition)
        {
            _log.LogError("");
            return _repository.Delete<WardAdmition>(WardAdmition);
        }

        public List<WardAdmition> GetAllWardAdmition()
        {
            _log.LogError("");
            return _repository.GetAll<WardAdmition>();
        }

        public WardAdmition FindWardAdmition(WardAdmition WardAdmition)
        {
            _log.LogError("");
            return _repository.Find<WardAdmition>(W=>W.ID==WardAdmition.ID);
        }

        
    }
}
