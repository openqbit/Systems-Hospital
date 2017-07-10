using OpenQbit.Hospital.Common.Models.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface ITreatmnetManager
    {
        bool RecoredTreatment(Treatment Treatment);
        bool EditTreatment(Treatment Treatment);
        bool DeleteTreatment(Treatment Treatment);
        List<Treatment> GetAllTreatment();
        Treatment FindTreatment(Treatment Treatment);
        
    }
}
