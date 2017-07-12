using OpenQbit.Hospital.Common.Models.opd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
   public interface IDescriptionManager
    {
        bool RecoredDescription(Description description);

        bool UpdataDescription(Description description);

        bool RemoveDescription(Description description);

        Description SearchDescription(String descriptionID);

        Array AllDescription();
    }
}
