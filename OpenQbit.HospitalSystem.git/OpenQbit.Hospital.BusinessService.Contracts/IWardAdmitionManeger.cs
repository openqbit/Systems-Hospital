using OpenQbit.Hospital.Common.Models.Ward;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Hospital.BusinessService.Contracts
{
    public interface IWardAdmitionManeger
    {
        
        bool RecoredWardAdmition(WardAdmition WardAdmition);
        bool EditWardAdmition(WardAdmition WardAdmition);
        bool DeleteWardAdmition(WardAdmition WardAdmition);
        List<WardAdmition> GetAllWardAdmition();
        WardAdmition FindWardAdmition(WardAdmition WardAdmition);
        
    }
}
