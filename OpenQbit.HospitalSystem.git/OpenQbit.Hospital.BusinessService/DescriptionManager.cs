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
    public class DescriptionManager : IDescriptionManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public DescriptionManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public Array AllDescription()
        {
            throw new NotImplementedException();
        }

        public bool RecoredDescription(Description description)
        {
            _log.LogError("");

            return _repository.Create<Description>(description);
        }

        public bool RemoveDescription(Description description)
        {
            _log.LogError("");

            return _repository.Delete<Description>(description);
        }

        public Description SearchDescription(string descriptionID)
        {
            throw new NotImplementedException();
        }

        public bool UpdataDescription(Description description)
        {
            _log.LogError("");

            return _repository.Update<Description>(description);
        }
    }
}
