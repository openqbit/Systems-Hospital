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

        [InjectionConstructor]    // Constructore  inject
        public InvoiceManger(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }


        [Dependency] //for setters
        public IRepository Repository
        {
            get { return _repository; }
            set { _repository = value; }
        }

        [Dependency] //for setters
        public ILogger Logger
        {
            get { return _log; }
            set { _log = value; }
        }


        [InjectionMethod] // for methodes
        public void SetRepository(IRepository repository)
        {
            _repository = repository;
        }

        public bool RecoredInventory(Ward ward)
        {
            throw new NotImplementedException();
        }
    }
}
