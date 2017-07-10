using OpenQbit.Hospital.Common.Models.Phamarcy.OpenQbit.Hospital.Common.Models.Phamarcy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IOrderManager
    {
        bool RecoredOrder(PharmacyOrders order);
        bool EditOrder(PharmacyOrders order);
        bool RemoveOrder(PharmacyOrders order);
        List<PharmacyOrders> GetAllOrders();
        PharmacyOrders FindOrders(PharmacyOrders order);
    }
}
