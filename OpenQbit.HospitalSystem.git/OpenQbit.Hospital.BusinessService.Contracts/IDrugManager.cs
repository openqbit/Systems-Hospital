using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IDrugManager
    {
        bool RecoredDrug(Drug drug);

        bool UpdataDrug(Drug drug);

        bool RemoveDrug(Drug drug);

        Drug Search(String drugID);

        Array AllDrug();
    }
}
