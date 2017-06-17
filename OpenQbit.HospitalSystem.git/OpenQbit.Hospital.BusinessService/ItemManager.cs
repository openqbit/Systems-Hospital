using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;

namespace OpenQbit.Hospital.BusinessService
{
    public class ItemManager :IItemManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]    // Constructore  inject
        public ResourceManger(IRepository repository, ILogger log)
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

        public bool RecoredInvoice(Resorce resorce) //Add Invoice
        {
            _log.LogError("");

            return _repository.Create<Resorce>(resorce);

            //throw new NotImplementedException();
        }

        public bool RecoredResorce(Resorce resource)
        {
            throw new NotImplementedException();
        }

        public bool RecoredManager(Item item)
        {
            throw new NotImplementedException();
        }
    }

}
}

