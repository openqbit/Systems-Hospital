using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface ITreatmentManager
    {
        bool RecoreRdecordsl(Treatment treatment);

        bool UpdataTreatment(Treatment treatment);

        bool RemoveTreatment(Treatment treatment);

        Treatment SearchTreatment(String recordID);

        Array AllTreatment();
    }
}
