using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;

namespace OpenQbit.Hospital.BusinessService
{
    class WardTypeManger : IWardTypeManager
    {
        private IRepository _repository;

        private ILogger _log;
        public WardTypeManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool DeleteWardType(WardType WardType)
        {
            _log.LogError("");
            return _repository.Delete<WardType>(WardType);
        }

        public bool EditWardType(WardType WardType)
        {
            _log.LogError("");
            return _repository.Update<WardType>(WardType);
        }
       
        public WardType FindWardType(WardType WardType)
        {
            _log.LogError("");
            return _repository.Find<WardType>(w => w.WardTypeId == WardType.WardTypeId);
        }

        public List<WardType> GetAllWardType()
        {
            _log.LogError("");
            return _repository.GetAll<WardType>();
        }

        public bool RecoredWardType(WardType WardType)
        {
            _log.LogError("");
            return _repository.Create<WardType>(WardType);
        }
    }
}
