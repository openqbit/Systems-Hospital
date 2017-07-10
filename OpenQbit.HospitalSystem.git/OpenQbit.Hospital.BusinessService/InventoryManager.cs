using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Ward;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class InventoryManager : IInventoryManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]   
        public InventoryManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredInventory(Ward ward)
        {
            _log.LogError("");

            return _repository.Create<Ward>(ward);
        }
    }
}
