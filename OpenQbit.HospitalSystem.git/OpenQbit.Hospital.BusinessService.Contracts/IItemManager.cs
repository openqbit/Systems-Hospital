using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IItemManager
    {
        bool RecoredItem(Item item);
        bool EditItem(Item item);
        bool RemoveItem(Item item);
        List<Item> GetAllItem();
        Item FindItem(Item item);
    }
}

