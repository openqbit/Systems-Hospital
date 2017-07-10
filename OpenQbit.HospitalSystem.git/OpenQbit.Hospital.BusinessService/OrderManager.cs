using OpenQbit.Hospital.BusinessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Hospital.Common.Models.Phamarcy.OpenQbit.Hospital.Common.Models.Phamarcy;
using OpenQbit.Hospital.DataAccess.DAL.Contracts;
using OpenQbit.Hospital.Common.Utils.Logs;
using Microsoft.Practices.Unity;

namespace OpenQbit.Hospital.BusinessService
{
    public class OrderManager : IOrderManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public OrderManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool RecoredOrder(PharmacyOrders order)
        {
            _log.LogError("");
            return _repository.Create<PharmacyOrders>(order);
        }

        public bool EditOrder(PharmacyOrders order)
        {
            _log.LogError("");
            return _repository.Update<PharmacyOrders>(order);
        }

        public bool RemoveOrder(PharmacyOrders order)
        {
            _log.LogError("");
            return _repository.Delete<PharmacyOrders>(order);
        }

        public List<PharmacyOrders> GetAllOrders()
        {
            _log.LogError("");
            return _repository.GetAll<PharmacyOrders>();
        }

        public PharmacyOrders FindOrders(PharmacyOrders order)
        {
            _log.LogError("");
            return _repository.Find<PharmacyOrders>(O => O.ID == order.ID);
        }
    }
}
