using OpenQbit.Hospital.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IWardTypeManager
    {
        bool RecoredWardType(WardType WardType);
        bool EditWardType(WardType WardType);
        bool DeleteWardType(WardType WardType);
        List<WardType> GetAllWardType();
        WardType FindWardType(WardType WardType);
        
    }
}
