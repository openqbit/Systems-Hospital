using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class ItemManager : IItemManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public ItemManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredItem(Item item)
        {
            _log.LogError("");

            return _repository.Create<Item>(item);
        }

        public bool EditItem(Item item)
        {
            _log.LogError("");
            return _repository.Update<Item>(item);
        }

        public bool RemoveItem(Item item)
        {
            _log.LogError("");
            return _repository.Delete<Item>(item);
        }

        public List<Item> GetAllItem()
        {
            _log.LogError("");
            return _repository.GetAll<Item>();
        }

        public Item FindItem(Item item)
        {
            _log.LogError("");
            return _repository.Find<Item>(I => I.ID == item.ID);
        }
    }
}
