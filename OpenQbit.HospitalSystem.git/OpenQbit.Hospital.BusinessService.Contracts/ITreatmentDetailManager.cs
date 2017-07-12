using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface ITreatmentDetailManager
    {
        bool RecoredTreatmentDetail(TreatmentDetail treatmentDetail);

        bool UpdataTreatmentDetail(TreatmentDetail treatmentDetail);

        bool RemoveTreatmentDetail(TreatmentDetail treatmentDetail);

        TreatmentDetail SearchTreatmentDetail(String TreatmentDetailID);

        Array AllTreatmentDetail();
    }
}
