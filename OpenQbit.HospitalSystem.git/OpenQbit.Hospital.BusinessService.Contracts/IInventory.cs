using OpenQbit.Hospital.Common.Models;
using OpenQbit.Hospital.Common.Models.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IInventory
    {
        bool RecoredInventory(Ward ward);
    }
}
