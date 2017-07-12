using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IDrugDetailManager
    {
        bool RecoredDrugDetail(DrugDetail drugDetail);

        bool UpdataDrugDetail(DrugDetail drugDetail);

        bool RemoveDrugDetail(DrugDetail drugDetail);

        DrugDetail SearchDrugDetail(String drugDetailID);

        Array AllDrugDetail();
    }
}
